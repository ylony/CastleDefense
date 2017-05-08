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
            this.gameArea.Click += new EventHandler(this.gameArea_Load);


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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void gameArea_Load(object sender, EventArgs e)
        {
            Graphics animated = gameArea.CreateGraphics();
            animated.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            animated.Clear(gameArea.BackColor);
            // Draw the house.
            Point[] pts = new Point[7];
            pts[0] = new Point(100, 100);
            pts[1] = new Point(pts[0].X, pts[0].Y - 10);
            pts[2] = new Point(pts[1].X - 10, pts[1].Y);
            pts[3] = new Point(pts[2].X + 10 + 10 / 2, pts[2].Y - 10 - 10 / 2);
            pts[4] = new Point(pts[3].X + 10 + 10 / 2, pts[2].Y);
            pts[5] = new Point(pts[4].X - 10, pts[1].Y);
            pts[6] = new Point(pts[5].X, pts[0].Y);
            animated.FillPolygon(Brushes.White, pts);
            animated.DrawPolygon(Pens.Blue, pts);;
            Pen myPen = new Pen(System.Drawing.Color.Blue, 15);
            //animated.DrawImage()
            animated.DrawLine(myPen, 20, 20, 200, 210);
            //animated.Save();
            //animated.Flush();
            //gameArea.Refresh();
            MessageBox.Show("refresh done");
        }

        private void gameArea_Click(object sender, EventArgs e)
        {

        }
    }
}
