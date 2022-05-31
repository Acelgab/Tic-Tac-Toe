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
            winner();

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
            winner();
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
            winner();
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
            winner();
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
            winner();
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
            winner();
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
            winner();
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
            winner();
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
            winner();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void winner()
        {

            if ((tile1.Text == tile4.Text) && (tile4.Text == tile7.Text) && (!tile1.Enabled))       
            {
                MessageBox.Show("Congratulation! You Won!");
            }
            else if ((tile2.Text == tile5.Text) && (tile5.Text == tile8.Text) && (!tile2.Enabled))
            {

                MessageBox.Show("Congratulation! You Won!");
            }
            else if ((tile3.Text == tile6.Text) && (tile6.Text == tile9.Text) && (!tile3.Enabled))
            {
                MessageBox.Show("Congratulation! You Won!");
            }
            else if ((tile1.Text == tile2.Text) && (tile2.Text == tile3.Text) && (!tile1.Enabled))
            {
                MessageBox.Show("Congratulation! You Won!");
            }
            else if ((tile4.Text == tile5.Text) && (tile5.Text == tile6.Text) && (!tile4.Enabled))
            {
                MessageBox.Show("Congratulation! You Won!");
            }
            else if ((tile7.Text == tile8.Text) && (tile8.Text == tile9.Text) && (!tile7.Enabled))
            {
                MessageBox.Show("Congratulation! You Won!");
            }
            else if ((tile1.Text == tile5.Text) && (tile5.Text == tile9.Text) && (!tile1.Enabled))
            {
                MessageBox.Show("Congratulation! You Won!");
            }
            else if ((tile3.Text == tile5.Text) && (tile5.Text == tile7.Text) && (!tile3.Enabled))
            {
                MessageBox.Show("Congratulation! You Won!");
            }

            
           
            



        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            tile1.Text = "";
            tile1.BackColor = Color.LightGreen;
            tile1.Enabled = true;
            tile2.Text = "";
            tile2.BackColor = Color.LightGreen;
            tile2.Enabled = true;
            tile3.Text = "";
            tile3.BackColor = Color.LightGreen;
            tile3.Enabled = true;
            tile4.Text = "";
            tile4.BackColor = Color.LightGreen;
            tile4.Enabled = true;
            tile5.Text = "";
            tile5.BackColor = Color.LightGreen;
            tile5.Enabled = true;
            tile6.Text = "";
            tile6.BackColor = Color.LightGreen;
            tile6.Enabled = true;
            tile7.Text = "";
            tile7.BackColor = Color.LightGreen;
            tile7.Enabled = true;
            tile8.Text = "";
            tile8.BackColor = Color.LightGreen;
            tile8.Enabled = true;
            tile9.Text = "";
            tile9.BackColor = Color.LightGreen;
            tile9.Enabled = true;
        }
    }
}
       
    
