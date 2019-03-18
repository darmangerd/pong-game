using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace EZSocket
{
    #region SocketMethode
    abstract public class SocketMethode
    {
        #region Déclaration des constante
        /// <summary>
        /// Taille du message
        /// </summary>
        protected const int BUFFERSIZE = 100;

        /// <summary>
        /// Port utilisé
        /// </summary>
        protected const int PORT = 27114;

        /// <summary>
        /// Port utilisé en jeu
        /// </summary>
        protected const int PORT_IN_GAME = 27115;

        /// <summary>
        /// Nombre maximum de connexion en même temps
        /// </summary>
        protected const int MAXCO = 10;
        #endregion

        #region Déclaration des variables
        protected AddressFamily AF;
        protected ProtocolType PT;
        protected SocketType ST;

        public bool Closed { get; protected set; }

        /// <summary>
        /// Socket utilisé pour envoyer et recevoir
        /// </summary>
        protected Socket socket;

        /// <summary>
        /// Addresse IP du poste
        /// </summary>
        protected string IPServeur;

        /// <summary>
        /// Thread pour recevoir en boucle
        /// </summary>
        protected Thread thread;
        #endregion

        #region Constructeur
        /// <summary>
        /// Met en place une connexion avec un serveur ou un client
        /// </summary>
        /// <param name="ipposte">Addresse IP du poste</param>
        /// <param name="protocoltype">Protocole utilisé</param>
        /// <param name="sockettype">Type de socket</param>
        /// <param name="addressfamily">Jsais pas trop, à laisser par défaut</param>
        public SocketMethode(string ipserveur, ProtocolType protocoltype = ProtocolType.Tcp, SocketType sockettype = SocketType.Stream, AddressFamily addressfamily = AddressFamily.InterNetwork)
        {
            this.IPServeur = ipserveur;
            this.AF = addressfamily;
            this.PT = protocoltype;
            this.ST = sockettype;
            this.Closed = false;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Envoie un message au client ou serveur
        /// </summary>
        /// <param name="message">Message à envoyer</param>
        /// <returns>Retourne false si échoue, sinon true</returns>
        public bool Send(string message)
        {
            try
            {
                socket.Send(Encoding.UTF8.GetBytes(message));
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Attend de recevoir un message
        /// </summary>
        /// <param name="message">Message reçu</param>
        /// <returns>Retourne false si échoue (perte de connexion ou autre) sinon true</returns>
        public bool Receive(out string message)
        {
            try
            {
                Byte[] buffer = new Byte[BUFFERSIZE];
                socket.Receive(buffer);
                message = Encoding.UTF8.GetString(DeleteZero(buffer));
                return true;
            }
            catch
            {
                message = string.Empty;
                return false;
            }
        }

        /// <summary>
        /// Attend de recevoir un message
        /// </summary>
        /// <returns>Retourne le message reçu</returns>
        public string Receive()
        {
            Byte[] buffer = new Byte[BUFFERSIZE];
            socket.Receive(buffer);
            return Encoding.UTF8.GetString(DeleteZero(buffer));
        }

        /// <summary>
        /// Attend de recevoir un message
        /// </summary>
        /// <param name="result">False si échoue, sinon true</param>
        /// <returns>Retourne le message reçu</returns>
        public string Receive(out bool result)
        {
            result = true;
            try
            {
                Byte[] buffer = new Byte[BUFFERSIZE];
                socket.Receive(buffer);
                return Encoding.UTF8.GetString(DeleteZero(buffer));
            }
            catch
            {
                result = false;
                return string.Empty;
            }
        }

        /// <summary>
        /// Ferme la connexion
        /// À utiliser à la fin du programme
        /// </summary>
        public void Close()
        {
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            Closed = true;
        }
        #endregion

        #region Fonctions
        private byte[] DeleteZero(byte[] bytes)
        {
            List<byte> lstByte = new List<byte>();
            foreach (byte b in bytes)
            {
                if (b != 0)
                {
                    lstByte.Add(b);
                }
            }
            return lstByte.ToArray();
        }
        #endregion
    }
    #endregion


    #region SocketClient
    public class SocketClient : SocketMethode
    {
        #region Constructeur
        /// <summary>
        /// Socket qui va se connecter à un serveur
        /// Initialisation de l'objet
        /// </summary>
        /// <param name="ipserveur">IP du serveur</param>
        /// <param name="protocoltype">Protocol voulu</param>
        /// <param name="sockettype">Type du socket</param>
        /// <param name="addressfamily">Famille de l'adresse</param>
        public SocketClient(string ipserveur, ProtocolType protocoltype = ProtocolType.Tcp, SocketType sockettype = SocketType.Stream, AddressFamily addressfamily = AddressFamily.InterNetwork) : base(ipserveur, protocoltype, sockettype, addressfamily)
        {
            this.IPServeur = ipserveur;
        }
        #endregion

        #region Méthodes
        public bool Connect()
        {
            try
            {
                this.socket = new Socket(AF, ST, PT);
                this.socket.Connect(new IPEndPoint(IPAddress.Parse(this.IPServeur), PORT_IN_GAME));
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Se connecter à une partie en fesant plusieurs essaie
        /// source : https://stackoverflow.com/questions/1905627/most-effective-way-to-connect-retry-connecting-using-c
        /// </summary>
        /// <returns></returns>
        public bool ConnectInGame()
        {
            bool bConnected = false;
            int iTry = 0;
            while (!bConnected)
            {
                try
                {
                    this.socket = new Socket(AF, ST, PT);
                    this.socket.Connect(new IPEndPoint(IPAddress.Parse(this.IPServeur), PORT));
                    bConnected = true;
                }
                catch
                {
                    System.Threading.Thread.Sleep(2000);

                    if (iTry == 5)
                    {
                        return false;
                    }
                    else
                    {
                        iTry++;
                        continue;
                    }

                }
            }
            return true;
        }
        /*public bool ConnectInGame()
        {
            try
            {
                this.socket = new Socket(AF, ST, PT);
                this.socket.Connect(new IPEndPoint(IPAddress.Parse(this.IPServeur), PORT));
                return true;
            }
            catch
            {
                return false;
            }         
        }*/


        #endregion
    }
    #endregion


    #region SocketServer
    public class SocketServer : SocketMethode
    {
        /// <summary>
        /// Socket pour une connexion qui écoute
        /// </summary>
        /// <param name="ipserveur">IP du serveur</param>
        /// <param name="protocoltype">Protocol voulu</param>
        /// <param name="sockettype">Type du socket</param>
        /// <param name="addressfamily">Famille de l'adresse</param>
        public SocketServer(string ipserveur, ProtocolType protocoltype = ProtocolType.Tcp, SocketType sockettype = SocketType.Stream, AddressFamily addressfamily = AddressFamily.InterNetwork) : base(ipserveur, protocoltype, sockettype, addressfamily)
        {

        }


        public void Wait()
        {
            this.socket = new Socket(AF, ST, PT);
            this.socket.Bind(new IPEndPoint(IPAddress.Parse(this.IPServeur), PORT_IN_GAME ));
            this.socket.Listen(MAXCO);
            this.socket = this.socket.Accept();
        }

        public void WaitInGame()
        {
            this.socket = new Socket(AF, ST, PT);
            this.socket.Bind(new IPEndPoint(IPAddress.Parse(this.IPServeur), PORT));
            this.socket.Listen(MAXCO);
            this.socket = this.socket.Accept();
        }
    }
    #endregion
}
