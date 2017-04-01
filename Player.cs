using System;
using System.Windows.Forms;
namespace CastleDefense
{
    public class Player
    {
        private String nom;
        private int points;
        private static int nbPlayers = 0;
        private Castle castle;

        public Player(String nom)
        {
            this.nom = nom;
            this.points = 0;
            if (nbPlayers == 0)
            {
                this.castle = new Castle(50, 500);
            }
            else
            {
                this.castle = new Castle(650, 500);
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
    }
}
