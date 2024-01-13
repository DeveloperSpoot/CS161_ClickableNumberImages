using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS161_ClickableNumberImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onePic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One");
        }

        private void twoPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Two");
        }

        private void threePic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Three");
        }

        private void fourPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Four");
        }

        private void fivePic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Five");
        }
    }
}
