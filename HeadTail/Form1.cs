using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeadTail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton(object sender, EventArgs e)
        {
            //Close The Form
            this.Close();
        }

        private void ShowTails(object sender, EventArgs e)
        {
            //Show the picture of a coin facing the Tails side
            this.pictureBox1.Visible = true;
            this.pictureBox2.Visible = false;

        }

        private void ShowHeads(object sender, EventArgs e)
        {
            //Show the picture of a coin facing the Heads side
            this.pictureBox2.Visible = true;
            this.pictureBox1.Visible = false;
        }
    }
}
