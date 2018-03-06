using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void FinishLabel_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            // if the player get to this place it shows congratulation
            MessageBox.Show("Congratulation You won");
            Close();
        }
        private void MoveToStart()
        {
            /// <summary>
            /// It set the cursor to the top left.
            /// </summary>
            Point startpoint = panel1.Location;
            startpoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startpoint);
        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            ///<summary>
            ///When a mouse cursor hit the wall then reset
            ///the cursor back to the start point
            /// </summary>

            MoveToStart();
        }
    }
}
