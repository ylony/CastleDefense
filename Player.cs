using System;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace CastleDefense
{
    public class Player
    {
        public String nom { get; set; }
        private int points;
        public static int nbPlayers = 0;
        private Castle castle;

        public Player(String nom)
        {
            this.nom = nom;
            this.points = 0;
            if (nbPlayers == 0)
            {
                this.castle = new Castle(50, 400);
            }
            else
            {
                this.castle = new Castle(650, 400);
            }
            nbPlayers++;
        }

        public String getNom()
        {
            return this.nom;
        }

        public Castle getCastle()
        {
            return this.castle;
        }

        public static int getNbPlayer()
        {
            return nbPlayers;
        }

        public void addPoints(int nb)
        {
            this.points = this.points + nb;
        }
        
        public MetroLabel DrawName()
        {
            MetroLabel drawname = new MetroLabel();
            if (nbPlayers == 1)
            {
                drawname.Location = new System.Drawing.Point(50, 370);
            }
            else
            {
                drawname.Location = new System.Drawing.Point(650, 370);
            }
            drawname.AutoSize = true;
            drawname.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            drawname.Text = this.getNom();
            drawname.Theme = MetroFramework.MetroThemeStyle.Dark;
            drawname.FontSize = MetroFramework.MetroLabelSize.Tall;
            return drawname;
        }

        public int getPoints()
        {
            return this.points;
        }
    }
}
