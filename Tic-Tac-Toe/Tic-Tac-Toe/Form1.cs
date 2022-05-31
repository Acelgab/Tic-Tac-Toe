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
            if (player1.BackColor == Color.Red)

            {
                player1.BackColor = Color.HotPink;
            }
        }
        private void tile1_Click(object sender, EventArgs e)
        {
            if (player1.BackColor == Color.Red)
            {
                tile1.Text = "X";
                tile1.BackColor = Color.HotPink;
            }
            else
            {
                tile1.Text = "O";
                tile1.BackColor = Color.DeepSkyBlue;
            }
            tile1.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tile2_Click(object sender, EventArgs e)
        {
            if (player1.BackColor == Color.Red)
            {
                tile2.Text = "X";
                tile2.BackColor = Color.HotPink;
            }
            else
            {
                tile2.Text = "O";
                tile2.BackColor = Color.DeepSkyBlue;
            }
            tile2.Enabled = false;
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            if (player1.BackColor == Color.Red)
            {
                tile3.Text = "X";
                tile3.BackColor = Color.HotPink;
            }
            else
            {
                tile3.Text = "O";
                tile3.BackColor = Color.DeepSkyBlue;
            }
            tile3.Enabled = false;
        }
        private void tile4_Click(object sender, EventArgs e)
        {
            if (player1.BackColor == Color.Red)
            {
                tile4.Text = "X";
                tile4.BackColor = Color.HotPink;
            }
            else
            {
                tile4.Text = "O";
                tile4.BackColor = Color.DeepSkyBlue;
            }
            tile4.Enabled = false;
        }
        private void tile5_Click(object sender, EventArgs e)
        {
            if (player1.BackColor == Color.Red)
            {
                tile5.Text = "X";
                tile5.BackColor = Color.HotPink;
            }
            else
            {
                tile5.Text = "O";
                tile5.BackColor = Color.DeepSkyBlue;
            }
            tile5.Enabled = false;
        }
        private void tile6_Click(object sender, EventArgs e)
        {
            if (player1.BackColor == Color.Red)
            {
                tile6.Text = "X";
                tile6.BackColor = Color.HotPink;
            }
            else
            {
                tile6.Text = "O";
                tile6.BackColor = Color.DeepSkyBlue;
            }
            tile6.Enabled = false;
        }
        private void tile7_Click(object sender, EventArgs e)
        {
            if (player1.BackColor == Color.Red)
            {
                tile7.Text = "X";
                tile7.BackColor = Color.HotPink;
            }
            else
            {
                tile7.Text = "O";
                tile7.BackColor = Color.DeepSkyBlue;
            }
            tile7.Enabled = false;
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
        
   

        private void tile8_Click(object sender, EventArgs e)
        {
            if (player1.BackColor == Color.Red)
            {
                tile8.Text = "X";
                tile8.BackColor = Color.HotPink;
            }
            else
            {
                tile8.Text = "O";
                tile8.BackColor = Color.DeepSkyBlue;
            }
            tile8.Enabled = false;
        }
        
         private void tile9_Click(object sender, EventArgs e)
         {
            if (player1.BackColor == Color.Red)
            {
                tile9.Text = "X";
                tile9.BackColor = Color.HotPink;
            }
            else
            {
                tile9.Text = "O";
                tile9.BackColor = Color.DeepSkyBlue;
            }
            tile9.Enabled = false;
         }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
       
    
