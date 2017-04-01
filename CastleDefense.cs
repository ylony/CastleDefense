using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CastleDefense
{
    public partial class CastleDefense : MetroFramework.Forms.MetroForm
    {
        //Config
        private int maxPlayers = 2;
        //
        public CastleDefense()
        {
            InitializeComponent();
        }

        private void CastleDefense_Load(object sender, EventArgs e)
        {
           Player maurice = this.addPlayer("Maurice");
           Player kevin = this.addPlayer("Kevin");
           this.Controls.Add(maurice.getCastle().DrawCastle());
           this.Controls.Add(kevin.getCastle().DrawCastle());
        }

        private Player addPlayer(String nom)
        {
            if (Player.getNbPlayer() < maxPlayers)
            {
                Player newPlayer = new Player(nom);
                return newPlayer;
            }
            else
            {
                Console.WriteLine("Nombre de joueur maximum atteint impossible d'en rajouter.");
                return null;
            }
        }
    }
}
