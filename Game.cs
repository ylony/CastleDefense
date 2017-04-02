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

    }
}
