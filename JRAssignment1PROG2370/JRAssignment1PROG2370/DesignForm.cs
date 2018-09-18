using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JRAssignment1PROG2370
{
    public partial class DesignForm : Form
    {
        public string resource = "";
        int rows = 0;
        int columns = 0;

        public struct DynamicPictureBox{
            int pictureValue;
            PictureBox dynamicPB;

            public DynamicPictureBox(PictureBox pb, int picValue)
            {
                pictureValue = picValue;
                dynamicPB = pb;
            }
        }
        public DesignForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            rows = int.Parse(txtRows.Text);
            columns = int.Parse(txtColumns.Text);

            PictureBox[,] pba = new PictureBox[rows,columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    pba[i, j] = new PictureBox();
                    pba[i, j].Location = new Point(int.Parse(pnlGrid.Location.X.ToString()) + j * 50, int.Parse(pnlGrid.Location.Y.ToString()) + i * 50);
                    pba[i, j].Width = 50;
                    pba[i, j].Height = 50;
                    pba[i, j].Visible = true;
                    pba[i, j].BorderStyle = BorderStyle.FixedSingle;
                    pba[i, j].BringToFront();
                    pba[i, j].Click += pb_Click;
                    pba[i,j].BackgroundImageLayout = ImageLayout.Stretch;   
                    pnlGrid.Controls.Add(pba[i, j]);
                }
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {
            var pb = sender as PictureBox;
            switch (resource)
            {
                case "btnNone":
                    pb.BackgroundImage = null;
                    pb.BackgroundImage.
                    break;
                case "btnWall":
                    pb.BackgroundImage = Properties.Resources.Wall;
                    break;
                case "btnRedDoor":
                    pb.BackgroundImage = Properties.Resources.redDoor;
                    break;
                case "btnGreenDoor":
                    pb.BackgroundImage = Properties.Resources.greenDoor;
                    break;
                case "btnBlueDoor":
                    pb.BackgroundImage = Properties.Resources.blueDoor;
                    break;
                case "btnYellowDoor":
                    pb.BackgroundImage = Properties.Resources.yellowDoor;
                    break;
                case "btnRedBox":
                    pb.BackgroundImage = Properties.Resources.redBox;
                    break;
                case "btnGreenBox":
                    pb.BackgroundImage = Properties.Resources.greenBox;
                    break;
                case "btnBlueBox":
                    pb.BackgroundImage = Properties.Resources.blueBox;
                    break;
                case "btnYellowBox":
                    pb.BackgroundImage = Properties.Resources.yellowBox;
                    break;
                default:
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var pb = sender as Button;
            resource = pb.Name;
            //resource = sender.ToString().Substring(3);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
