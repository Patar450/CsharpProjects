using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveToFile
{
    public partial class txtLocation : Form
    {
        public txtLocation()
        {
            InitializeComponent();
        }

        private void infotosave_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            StreamWriter output;

            output = new StreamWriter(txtloc.Text, true);
            MessageBox.Show(infotosave.Text + "Has been saved");
            output.WriteLine(infotosave.Text + DateTime.Now.ToString("h:mm:ss tt"));
            infotosave.Clear();

            output.Close();
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            StreamReader input;
            input = new StreamReader(txtloc.Text);
            infotosave.Text = input.ReadToEnd();
            
            input.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter output;

            output = new StreamWriter(txtloc.Text);
            MessageBox.Show("previous info has been replaced with: " + infotosave.Text );
            output.WriteLine(infotosave.Text + DateTime.Now.ToString("h:mm:ss tt"));
            infotosave.Clear();

            output.Close();
        }
    }
}
