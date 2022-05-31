using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class board : Form
    {
        public board()
        {
            InitializeComponent();
        }

        private void player1_Click(object sender, EventArgs e)
        {
            // kapag pinindot yung player, dapat mag iba color ng button
  
            player1.BackColor = Color.Red;
            if (player2.BackColor == Color.Red)
            {
                player2.BackColor = Color.DeepSkyBlue;
            }

            

     
        }

        private void player2_Click(object sender, EventArgs e)
        {
            player2.BackColor = Color.Red;
            if (player1.BackColor==Color.Red)
               
            {
                player1.BackColor = Color.DeepSkyBlue;
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tile2_Click(object sender, EventArgs e)
        {

        }

        private void tile3_Click(object sender, EventArgs e)
        {

        }

        private void tile9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void board_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void instruction1_Click(object sender, EventArgs e)
        {

        }
    }
}
