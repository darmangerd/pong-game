using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    class Player
    {
        #region Déclaration des variables

        /// <summary>
        /// Nom du joueurs
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ID du joueur (venant de la base de données)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Score du joueur
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Set gagné par le joueur
        /// </summary>
        public int WinSet { get; set; }

        /// <summary>
        /// Bool utilisé pour la détection de la posibilité de déplacement vers le haut du joueur
        /// </summary>
        public bool MoveUp { get; set; }

        /// <summary>
        /// Bool utilisé pour la détection de la posibilité de déplacement vers le bas du joueur
        /// </summary>
        public bool MoveDown { get; set; }

        #endregion

        #region Constructeur

        public Player()
        {
            Score = 0;
            WinSet = 0;
        }

        public Player(string name, int id)
        {
            this.Name = name;
            this.Id = id;
            Score = 0;
            WinSet = 0;
        }

        #endregion
    }
}
