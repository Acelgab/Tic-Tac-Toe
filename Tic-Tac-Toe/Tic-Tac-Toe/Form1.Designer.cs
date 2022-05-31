namespace Tic_Tac_Toe
{
    partial class board
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player1 = new System.Windows.Forms.Button();
            this.player2 = new System.Windows.Forms.Button();
            this.tile5 = new System.Windows.Forms.Button();
            this.tile8 = new System.Windows.Forms.Button();
            this.tile6 = new System.Windows.Forms.Button();
            this.tile4 = new System.Windows.Forms.Button();
            this.tile7 = new System.Windows.Forms.Button();
            this.tile3 = new System.Windows.Forms.Button();
            this.tile2 = new System.Windows.Forms.Button();
            this.tile9 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.border = new System.Windows.Forms.PictureBox();
            this.instruction1 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.tile1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.border)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.HotPink;
            this.player1.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.ForeColor = System.Drawing.Color.Black;
            this.player1.Location = new System.Drawing.Point(129, 57);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(75, 36);
            this.player1.TabIndex = 0;
            this.player1.Text = "Player 1";
            this.player1.UseVisualStyleBackColor = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.player2.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.ForeColor = System.Drawing.Color.Black;
            this.player2.Location = new System.Drawing.Point(250, 57);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(75, 36);
            this.player2.TabIndex = 1;
            this.player2.Text = "Player 2";
            this.player2.UseVisualStyleBackColor = false;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // tile5
            // 
            this.tile5.BackColor = System.Drawing.Color.LightGreen;
            this.tile5.Location = new System.Drawing.Point(171, 200);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(109, 78);
            this.tile5.TabIndex = 3;
            this.tile5.UseVisualStyleBackColor = false;
            this.tile5.Click += new System.EventHandler(this.tile5_Click);
            // 
            // tile8
            // 
            this.tile8.BackColor = System.Drawing.Color.LightGreen;
            this.tile8.Location = new System.Drawing.Point(171, 274);
            this.tile8.Name = "tile8";
            this.tile8.Size = new System.Drawing.Size(109, 78);
            this.tile8.TabIndex = 4;
            this.tile8.UseVisualStyleBackColor = false;
            this.tile8.Click += new System.EventHandler(this.tile8_Click);
            // 
            // tile6
            // 
            this.tile6.BackColor = System.Drawing.Color.LightGreen;
            this.tile6.Location = new System.Drawing.Point(277, 200);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(109, 78);
            this.tile6.TabIndex = 5;
            this.tile6.UseVisualStyleBackColor = false;
            this.tile6.Click += new System.EventHandler(this.tile6_Click);
            // 
            // tile4
            // 
            this.tile4.BackColor = System.Drawing.Color.LightGreen;
            this.tile4.Location = new System.Drawing.Point(64, 200);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(109, 78);
            this.tile4.TabIndex = 6;
            this.tile4.UseVisualStyleBackColor = false;
            this.tile4.Click += new System.EventHandler(this.tile4_Click);
            // 
            // tile7
            // 
            this.tile7.BackColor = System.Drawing.Color.LightGreen;
            this.tile7.Location = new System.Drawing.Point(64, 274);
            this.tile7.Name = "tile7";
            this.tile7.Size = new System.Drawing.Size(109, 78);
            this.tile7.TabIndex = 7;
            this.tile7.UseVisualStyleBackColor = false;
            this.tile7.Click += new System.EventHandler(this.tile7_Click);
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.LightGreen;
            this.tile3.Location = new System.Drawing.Point(277, 124);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(109, 78);
            this.tile3.TabIndex = 8;
            this.tile3.UseVisualStyleBackColor = false;
            this.tile3.Click += new System.EventHandler(this.tile3_Click);
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.LightGreen;
            this.tile2.Location = new System.Drawing.Point(171, 124);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(109, 78);
            this.tile2.TabIndex = 9;
            this.tile2.UseVisualStyleBackColor = false;
            this.tile2.Click += new System.EventHandler(this.tile2_Click);
            // 
            // tile9
            // 
            this.tile9.BackColor = System.Drawing.Color.LightGreen;
            this.tile9.Location = new System.Drawing.Point(277, 274);
            this.tile9.Name = "tile9";
            this.tile9.Size = new System.Drawing.Size(109, 78);
            this.tile9.TabIndex = 10;
            this.tile9.UseVisualStyleBackColor = false;
            this.tile9.Click += new System.EventHandler(this.tile9_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name.Font = new System.Drawing.Font("Snap ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.BlueViolet;
            this.name.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.name.Location = new System.Drawing.Point(12, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 51);
            this.name.TabIndex = 11;
            this.name.Text = "TIC \r\nTAC \r\nTOE";
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // border
            // 
            this.border.BackgroundImage = global::Tic_Tac_Toe.Properties.Resources.image_2022_05_30_155419422_removebg_preview;
            this.border.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.border.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.border.Location = new System.Drawing.Point(41, 99);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(366, 280);
            this.border.TabIndex = 12;
            this.border.TabStop = false;
            this.border.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // instruction1
            // 
            this.instruction1.AutoSize = true;
            this.instruction1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction1.ForeColor = System.Drawing.Color.Black;
            this.instruction1.Location = new System.Drawing.Point(95, 24);
            this.instruction1.Name = "instruction1";
            this.instruction1.Size = new System.Drawing.Size(274, 30);
            this.instruction1.TabIndex = 13;
            this.instruction1.Text = "Please choose the player before choosing a tile.\r\n\r\n";
            this.instruction1.Click += new System.EventHandler(this.instruction1_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.BlueViolet;
            this.btnRestart.Location = new System.Drawing.Point(311, 400);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(96, 33);
            this.btnRestart.TabIndex = 14;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightGreen;
            this.tile1.Location = new System.Drawing.Point(64, 124);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(109, 78);
            this.tile1.TabIndex = 15;
            this.tile1.UseVisualStyleBackColor = false;
            this.tile1.Click += new System.EventHandler(this.tile1_Click);
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(450, 445);
            this.Controls.Add(this.tile1);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.instruction1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.tile9);
            this.Controls.Add(this.tile2);
            this.Controls.Add(this.tile3);
            this.Controls.Add(this.tile7);
            this.Controls.Add(this.tile4);
            this.Controls.Add(this.tile6);
            this.Controls.Add(this.tile8);
            this.Controls.Add(this.tile5);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.border);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "board";
            this.Text = "Play Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.board_Load);
            ((System.ComponentModel.ISupportInitialize)(this.border)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button player1;
        private System.Windows.Forms.Button player2;
        private System.Windows.Forms.Button tile5;
        private System.Windows.Forms.Button tile8;
        private System.Windows.Forms.Button tile6;
        private System.Windows.Forms.Button tile4;
        private System.Windows.Forms.Button tile7;
        private System.Windows.Forms.Button tile3;
        private System.Windows.Forms.Button tile2;
        private System.Windows.Forms.Button tile9;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox border;
        private System.Windows.Forms.Label instruction1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button tile1;
    }
}

