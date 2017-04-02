using System;
using System.Windows.Forms;

namespace CastleDefense
{
    public class Castle
    {
        private int ptsDeVie = 100;
        Boolean alive;
        private int x, y;

        public Castle(int x, int y)
        {
            this.alive = true;
            this.x = x;
            this.y = y;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public PictureBox DrawCastle()
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "./ressources/castle.png";
            pb1.SizeMode = PictureBoxSizeMode.AutoSize;
            pb1.Location = new System.Drawing.Point(x, y);
            return pb1;
        }

        public Boolean isAlive()
        {
            return this.alive;
        }
        
        override
        public String ToString()
        {
            if (isAlive())
            {
                return "La château est encore en vie et possède : " + ptsDeVie;
            }
            return "Le château est détruit";
       }
    }
}
