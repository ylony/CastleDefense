using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastleDefense
{
    public partial class Panel : MetroFramework.Forms.MetroForm
    {
        public static Player p1 = new Player("p1");
        public static Player p2 = new Player(null);
        private CastleDefense game;
        public Panel(CastleDefense game)
        {
            InitializeComponent();
            this.game = game;
            game.config = this;
        }

        private int getNumberElement()
        {
            int i = 0;
            foreach (var test in this.Controls)
            {
                i++;
            }
            return i;
        }

        private void change1p(object sender, System.EventArgs e)
        {
            TextBox aux;
            aux = (TextBox)sender;
            Panel.p1.nom = aux.Text;
        }

        private void panelClicOne(object sender, System.EventArgs e)
        {
            int i = this.Controls.IndexOf((Control)sender) + 1;
           // var test = new CastleDefense();
            Player p1 = new Player("player1");
            this.Controls.RemoveAt(i);
            this.Controls.Remove((Control)sender);
            MetroLabel title = new MetroLabel();
            title.Text = "One Player Mode";
            title.Location = new Point(120, 100);
            title.Theme = MetroFramework.MetroThemeStyle.Dark;
            title.Width = 120;
            MetroLabel dname = new MetroLabel();
            dname.Text = "Nom du joueur : ";
            dname.Location = new Point(50, 150);
            dname.Width = 120;
            dname.Theme = MetroFramework.MetroThemeStyle.Dark;
            TextBox in_player1 = new TextBox();
            in_player1.Text = "Player 1";
            in_player1.Location = new Point(200, 150);
            in_player1.TextChanged += new EventHandler(this.change1p);
            MetroButton valid = new MetroButton();
            valid.Text = "Begin !";
            valid.Location = new Point(140, 300);
            valid.Theme = MetroFramework.MetroThemeStyle.Dark;
            valid.Click += new EventHandler(this.validOnClic);
            this.Controls.Add(valid);
            this.Controls.Add(title);
            this.Controls.Add(dname);
            this.Controls.Add(in_player1);
            //test.Show();
        }

        private void validOnClic(object sender, System.EventArgs e)
        {
            this.Hide();
            game.startGame();
        }

        private void panelClicMulti(object sender, System.EventArgs e)
        {
            int i = this.Controls.IndexOf((Control)sender)-1;
           // var test = new CastleDefense();
            this.Controls.RemoveAt(i);
            this.Controls.Remove((Control)sender);
            TextBox in_player1 = new TextBox();
            in_player1.Text = "Player 1";
            in_player1.Location = new Point(200, 100);

            //test.Show();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            MetroButton focus = new MetroButton();
            focus.Hide();
            MetroButton OnePlayer = new MetroButton();
            OnePlayer.Location = new Point(120, 100);
            OnePlayer.Text = "Un joueur";
            OnePlayer.Size = new Size(140, 50);
            OnePlayer.Click += new EventHandler(this.panelClicOne);
            OnePlayer.Theme = MetroFramework.MetroThemeStyle.Dark;
            MetroButton MultiPlayer = new MetroButton();
            MultiPlayer.Location = new Point(120, 200);
            MultiPlayer.Size = new Size(140, 50);
            MultiPlayer.Text = "Deux joueurs";
            MultiPlayer.Click += new EventHandler(this.panelClicMulti);
            MultiPlayer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Controls.Add(focus);
            this.Controls.Add(OnePlayer);
            this.Controls.Add(MultiPlayer);
            focus.Select();
        }
    }
}
