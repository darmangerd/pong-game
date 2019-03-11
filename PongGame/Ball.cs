using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public class Ball
    {
        #region déclaration des variables

        /// <summary>
        /// Vitesse de déplacement de la balle en vertical x
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Vitesse de déplacement de la balle en vertical y
        /// </summary>
        public int y { get; set; }

        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur de la class ball
        /// </summary>
        /// <param name="speedX">Vitesse de déplacement de la balle en horizontal (axe x)</param>
        /// <param name="speedY">Vitesse de déplacement de la balle en vertical (axe y)</param>
        public Ball(int speedX, int speedY)
        {
            this.x = speedX;
            this.y = speedY;
        }

        #endregion
    }
}
