using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastleDefense
{
    class Game
    {
        public Game()
        {

        }

        public PictureBox DrawGround()
        {
            PictureBox ground = new PictureBox();
            ground.Location = new System.Drawing.Point(0, 481);
            ground.ImageLocation = "./ressources/ground.png";
            ground.Name = "Ground";
            ground.SizeMode = PictureBoxSizeMode.AutoSize;
            ground.TabIndex = 0;
            ground.TabStop = false;
            return ground;
        }

        public MetroLabel DrawScore(Player p1, Player p2)
        {
            MetroLabel score = new MetroLabel();
            score.Text = p1.getPoints().ToString();
            if (Player.getNbPlayer() == 1)
            {
                score.Location = new System.Drawing.Point(50, 50);
            }
            else
            {
                score.Location = new System.Drawing.Point(650, 50);
            }
            score.Text = p1.getPoints().ToString();
            score.AutoSize = true;
            score.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            score.Theme = MetroFramework.MetroThemeStyle.Dark;
            score.FontSize = MetroFramework.MetroLabelSize.Tall;
            return score;
        }

    }
}
