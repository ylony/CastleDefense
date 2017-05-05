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
        public Panel config;
        //Config
        private int maxPlayers = 2;
        //
        public CastleDefense(Panel config)
        {
            InitializeComponent();
            this.config = config;
            this.FormClosed += new FormClosedEventHandler(this.closeqt);
        }

        private void CastleDefense_Load(object sender, EventArgs e)
        {
            
        }

        private void closeqt(object sender, EventArgs e)
        {
            config.Close();
        }

        public void startGame()
        {
            Player.nbPlayers = 0;
            Player aux = this.addPlayer(Panel.p1.nom);
            Player aux2;
            if (Panel.p2.nom == null)
            {
                aux2 = this.addPlayer("IA");
            }
            else
            {
                aux2 = this.addPlayer(Panel.p2.nom);
            }
            Game game = new Game();
            this.Controls.Add(game.DrawGround());
            this.Controls.Add(game.DrawScore(aux, aux2));
            this.Show();
        }

        private Player addPlayer(String nom)
        {
            if (Player.getNbPlayer() < maxPlayers)
            {
                Player newPlayer = new Player(nom);
                this.Controls.Add(newPlayer.getCastle().DrawCastle());
                this.Controls.Add(newPlayer.DrawName());
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
