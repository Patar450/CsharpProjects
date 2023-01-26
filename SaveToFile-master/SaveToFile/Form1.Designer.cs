namespace SaveToFile
{
    partial class txtLocation
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
            this.btnsave = new System.Windows.Forms.Button();
            this.txtloc = new System.Windows.Forms.TextBox();
            this.lblloc = new System.Windows.Forms.Label();
            this.infotosave = new System.Windows.Forms.TextBox();
            this.txtsave = new System.Windows.Forms.Label();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.ReplaceandSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(208, 112);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(149, 48);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "ADD and S A V E";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtloc
            // 
            this.txtloc.Location = new System.Drawing.Point(30, 83);
            this.txtloc.Name = "txtloc";
            this.txtloc.Size = new System.Drawing.Size(408, 22);
            this.txtloc.TabIndex = 1;
            // 
            // lblloc
            // 
            this.lblloc.AutoSize = true;
            this.lblloc.Location = new System.Drawing.Point(30, 61);
            this.lblloc.Name = "lblloc";
            this.lblloc.Size = new System.Drawing.Size(106, 16);
            this.lblloc.TabIndex = 2;
            this.lblloc.Text = "Location on Disk";
            // 
            // infotosave
            // 
            this.infotosave.Location = new System.Drawing.Point(30, 36);
            this.infotosave.Name = "infotosave";
            this.infotosave.Size = new System.Drawing.Size(408, 22);
            this.infotosave.TabIndex = 3;
            this.infotosave.TextChanged += new System.EventHandler(this.infotosave_TextChanged);
            // 
            // txtsave
            // 
            this.txtsave.AutoSize = true;
            this.txtsave.Location = new System.Drawing.Point(33, 14);
            this.txtsave.Name = "txtsave";
            this.txtsave.Size = new System.Drawing.Size(80, 16);
            this.txtsave.TabIndex = 4;
            this.txtsave.Text = "Text to save";
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(30, 112);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(93, 47);
            this.Loadbtn.TabIndex = 5;
            this.Loadbtn.Text = "L O A D";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // ReplaceandSave
            // 
            this.ReplaceandSave.Location = new System.Drawing.Point(363, 111);
            this.ReplaceandSave.Name = "ReplaceandSave";
            this.ReplaceandSave.Size = new System.Drawing.Size(167, 49);
            this.ReplaceandSave.TabIndex = 6;
            this.ReplaceandSave.Text = "Replace and S A V E";
            this.ReplaceandSave.UseVisualStyleBackColor = true;
            this.ReplaceandSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 173);
            this.Controls.Add(this.ReplaceandSave);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.txtsave);
            this.Controls.Add(this.infotosave);
            this.Controls.Add(this.lblloc);
            this.Controls.Add(this.txtloc);
            this.Controls.Add(this.btnsave);
            this.Name = "txtLocation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtloc;
        private System.Windows.Forms.Label lblloc;
        private System.Windows.Forms.TextBox infotosave;
        private System.Windows.Forms.Label txtsave;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button ReplaceandSave;
    }
}

