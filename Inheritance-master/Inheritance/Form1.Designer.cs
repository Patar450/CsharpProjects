namespace Inheritance
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
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txbxuser = new System.Windows.Forms.TextBox();
            this.txbxpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(17, 35);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(70, 16);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(17, 97);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(67, 16);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // txbxuser
            // 
            this.txbxuser.Location = new System.Drawing.Point(20, 54);
            this.txbxuser.Name = "txbxuser";
            this.txbxuser.Size = new System.Drawing.Size(178, 22);
            this.txbxuser.TabIndex = 2;
            // 
            // txbxpassword
            // 
            this.txbxpassword.Location = new System.Drawing.Point(20, 115);
            this.txbxpassword.Name = "txbxpassword";
            this.txbxpassword.Size = new System.Drawing.Size(178, 22);
            this.txbxpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(124, 164);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 28);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txbxpassword);
            this.Controls.Add(this.txbxuser);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbluser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txbxuser;
        private System.Windows.Forms.TextBox txbxpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button button1;
    }
}

