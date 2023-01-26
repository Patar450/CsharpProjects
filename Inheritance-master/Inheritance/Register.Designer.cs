namespace Inheritance
{
    partial class Register
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
            this.txbxname = new System.Windows.Forms.TextBox();
            this.txbxusername = new System.Windows.Forms.TextBox();
            this.txbxpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbxadmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txbxname
            // 
            this.txbxname.Location = new System.Drawing.Point(156, 22);
            this.txbxname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbxname.Name = "txbxname";
            this.txbxname.Size = new System.Drawing.Size(128, 20);
            this.txbxname.TabIndex = 0;
            // 
            // txbxusername
            // 
            this.txbxusername.Location = new System.Drawing.Point(156, 72);
            this.txbxusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbxusername.Name = "txbxusername";
            this.txbxusername.Size = new System.Drawing.Size(128, 20);
            this.txbxusername.TabIndex = 1;
            // 
            // txbxpassword
            // 
            this.txbxpassword.Location = new System.Drawing.Point(156, 121);
            this.txbxpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbxpassword.Name = "txbxpassword";
            this.txbxpassword.Size = new System.Drawing.Size(128, 20);
            this.txbxpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "What is your name?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "what will be your username?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Create a password.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbxadmin
            // 
            this.ckbxadmin.AutoSize = true;
            this.ckbxadmin.Location = new System.Drawing.Point(142, 157);
            this.ckbxadmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbxadmin.Name = "ckbxadmin";
            this.ckbxadmin.Size = new System.Drawing.Size(113, 17);
            this.ckbxadmin.TabIndex = 7;
            this.ckbxadmin.Text = "Wanna be admin?";
            this.ckbxadmin.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 228);
            this.Controls.Add(this.ckbxadmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbxpassword);
            this.Controls.Add(this.txbxusername);
            this.Controls.Add(this.txbxname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxname;
        private System.Windows.Forms.TextBox txbxusername;
        private System.Windows.Forms.TextBox txbxpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbxadmin;
    }
}