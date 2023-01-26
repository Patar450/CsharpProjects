namespace Pig_the_game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ListPlayer1 = new System.Windows.Forms.ListBox();
            this.ListPlayer2 = new System.Windows.Forms.ListBox();
            this.CurrentPlayer = new System.Windows.Forms.Label();
            this.DiceRoll = new System.Windows.Forms.Label();
            this.lblplyr = new System.Windows.Forms.Label();
            this.lblTotalSc1 = new System.Windows.Forms.Label();
            this.lblTotalSc2 = new System.Windows.Forms.Label();
            this.lblttotscp1 = new System.Windows.Forms.Label();
            this.lblttotscp2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttbply1 = new System.Windows.Forms.TextBox();
            this.txttbply2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "2 players. 1 dice. ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pig";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Game is won when a player gets 100 points.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player loses all current points if he gets 1.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Player has the option to hold the current accumulated points.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Move round to the next player.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(308, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rules";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Roll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 286);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hold";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListPlayer1
            // 
            this.ListPlayer1.FormattingEnabled = true;
            this.ListPlayer1.Location = new System.Drawing.Point(346, 36);
            this.ListPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListPlayer1.Name = "ListPlayer1";
            this.ListPlayer1.Size = new System.Drawing.Size(101, 186);
            this.ListPlayer1.TabIndex = 9;
            // 
            // ListPlayer2
            // 
            this.ListPlayer2.FormattingEnabled = true;
            this.ListPlayer2.Location = new System.Drawing.Point(468, 36);
            this.ListPlayer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListPlayer2.Name = "ListPlayer2";
            this.ListPlayer2.Size = new System.Drawing.Size(101, 186);
            this.ListPlayer2.TabIndex = 10;
            // 
            // CurrentPlayer
            // 
            this.CurrentPlayer.AutoSize = true;
            this.CurrentPlayer.Location = new System.Drawing.Point(10, 199);
            this.CurrentPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentPlayer.Name = "CurrentPlayer";
            this.CurrentPlayer.Size = new System.Drawing.Size(70, 13);
            this.CurrentPlayer.TabIndex = 11;
            this.CurrentPlayer.Text = "CurrentPlayer";
            // 
            // DiceRoll
            // 
            this.DiceRoll.AutoSize = true;
            this.DiceRoll.Location = new System.Drawing.Point(120, 286);
            this.DiceRoll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiceRoll.Name = "DiceRoll";
            this.DiceRoll.Size = new System.Drawing.Size(41, 13);
            this.DiceRoll.TabIndex = 12;
            this.DiceRoll.Text = "<Dice>";
            // 
            // lblplyr
            // 
            this.lblplyr.AutoSize = true;
            this.lblplyr.Location = new System.Drawing.Point(10, 219);
            this.lblplyr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplyr.Name = "lblplyr";
            this.lblplyr.Size = new System.Drawing.Size(93, 13);
            this.lblplyr.TabIndex = 13;
            this.lblplyr.Text = "Amount of Rolls: 0";
            // 
            // lblTotalSc1
            // 
            this.lblTotalSc1.AutoSize = true;
            this.lblTotalSc1.Location = new System.Drawing.Point(9, 21);
            this.lblTotalSc1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSc1.Name = "lblTotalSc1";
            this.lblTotalSc1.Size = new System.Drawing.Size(90, 13);
            this.lblTotalSc1.TabIndex = 14;
            this.lblTotalSc1.Text = "Total for Player 1:";
            this.lblTotalSc1.Click += new System.EventHandler(this.lblTotalSc1_Click);
            // 
            // lblTotalSc2
            // 
            this.lblTotalSc2.AutoSize = true;
            this.lblTotalSc2.Location = new System.Drawing.Point(9, 47);
            this.lblTotalSc2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSc2.Name = "lblTotalSc2";
            this.lblTotalSc2.Size = new System.Drawing.Size(90, 13);
            this.lblTotalSc2.TabIndex = 15;
            this.lblTotalSc2.Text = "Total for Player 2:";
            // 
            // lblttotscp1
            // 
            this.lblttotscp1.AutoSize = true;
            this.lblttotscp1.Location = new System.Drawing.Point(358, 240);
            this.lblttotscp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblttotscp1.Name = "lblttotscp1";
            this.lblttotscp1.Size = new System.Drawing.Size(81, 13);
            this.lblttotscp1.TabIndex = 16;
            this.lblttotscp1.Text = "Total Score P1:";
            // 
            // lblttotscp2
            // 
            this.lblttotscp2.AutoSize = true;
            this.lblttotscp2.Location = new System.Drawing.Point(475, 240);
            this.lblttotscp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblttotscp2.Name = "lblttotscp2";
            this.lblttotscp2.Size = new System.Drawing.Size(81, 13);
            this.lblttotscp2.TabIndex = 17;
            this.lblttotscp2.Text = "Total Score P2:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalSc2);
            this.groupBox2.Controls.Add(this.lblTotalSc1);
            this.groupBox2.Location = new System.Drawing.Point(183, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(134, 81);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Round Scores";
            // 
            // txttbply1
            // 
            this.txttbply1.Location = new System.Drawing.Point(376, 257);
            this.txttbply1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttbply1.Name = "txttbply1";
            this.txttbply1.Size = new System.Drawing.Size(31, 20);
            this.txttbply1.TabIndex = 19;
            this.txttbply1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttbply2
            // 
            this.txttbply2.Location = new System.Drawing.Point(496, 257);
            this.txttbply2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttbply2.Name = "txttbply2";
            this.txttbply2.Size = new System.Drawing.Size(31, 20);
            this.txttbply2.TabIndex = 20;
            this.txttbply2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pig_the_game.Properties.Resources.external_content_duckduckgo_com;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txttbply2);
            this.Controls.Add(this.txttbply1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblttotscp2);
            this.Controls.Add(this.lblttotscp1);
            this.Controls.Add(this.lblplyr);
            this.Controls.Add(this.DiceRoll);
            this.Controls.Add(this.CurrentPlayer);
            this.Controls.Add(this.ListPlayer2);
            this.Controls.Add(this.ListPlayer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox ListPlayer1;
        private System.Windows.Forms.ListBox ListPlayer2;
        private System.Windows.Forms.Label CurrentPlayer;
        private System.Windows.Forms.Label DiceRoll;
        private System.Windows.Forms.Label lblplyr;
        private System.Windows.Forms.Label lblTotalSc1;
        private System.Windows.Forms.Label lblTotalSc2;
        private System.Windows.Forms.Label lblttotscp1;
        private System.Windows.Forms.Label lblttotscp2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttbply1;
        private System.Windows.Forms.TextBox txttbply2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

