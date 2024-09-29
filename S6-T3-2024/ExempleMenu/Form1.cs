using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempleMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;


        }

        private void vertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Green;
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
