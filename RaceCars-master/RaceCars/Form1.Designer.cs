namespace RaceCars
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
            this.lstbxname = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btncnt = new System.Windows.Forms.Button();
            this.btnrace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbxname
            // 
            this.lstbxname.FormattingEnabled = true;
            this.lstbxname.Location = new System.Drawing.Point(12, 12);
            this.lstbxname.Name = "lstbxname";
            this.lstbxname.Size = new System.Drawing.Size(723, 160);
            this.lstbxname.TabIndex = 0;
            this.lstbxname.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 195);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(723, 381);
            this.listBox2.TabIndex = 1;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // btncnt
            // 
            this.btncnt.Location = new System.Drawing.Point(741, 12);
            this.btncnt.Name = "btncnt";
            this.btncnt.Size = new System.Drawing.Size(75, 23);
            this.btncnt.TabIndex = 2;
            this.btncnt.Text = "Contestants";
            this.btncnt.UseVisualStyleBackColor = true;
            this.btncnt.Click += new System.EventHandler(this.btncnt_Click);
            // 
            // btnrace
            // 
            this.btnrace.Location = new System.Drawing.Point(741, 195);
            this.btnrace.Name = "btnrace";
            this.btnrace.Size = new System.Drawing.Size(75, 23);
            this.btnrace.TabIndex = 3;
            this.btnrace.Text = "Race";
            this.btnrace.UseVisualStyleBackColor = true;
            this.btnrace.Click += new System.EventHandler(this.btnrace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 628);
            this.Controls.Add(this.btnrace);
            this.Controls.Add(this.btncnt);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lstbxname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxname;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btncnt;
        private System.Windows.Forms.Button btnrace;
    }
}

