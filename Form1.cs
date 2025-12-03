using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_Git
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ptint()
        {
            MessageBox.Show("You Pressed Button 1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ptint();
        }
    }
}
