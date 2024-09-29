using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devin
{
    public partial class Form1 : Form
    {
        private int nbSecret;
        private int cpt;

        private bool gagne;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "JOUEZ!";
            label1.Text = "";
            label2.Text = "lab";
           
            label2.BackColor = Color.Yellow; label2.ForeColor= Color.Red;
           
            Random r = new Random();
            nbSecret = r.Next(0, 100);
            this.Text = nbSecret.ToString();

            this.cpt = 6;
            this.gagne = false;

            button2.Text = "REJOUEZ ?";
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int proposition;
            String s = textBox1.Text;
            //proposition = Convert.ToInt32(s);
            //Int32.TryParse(s, out proposition);
            bool indicateur = int.TryParse(s, out proposition);
            if (indicateur == false)
            {
                // On n’a pas affaire à un entier. Ya « rien » dans la variable nombre.
                label1.ForeColor = Color.Black;
                label1.Text = "On a dit un entier abruti !";
                textBox1.Text = "";
                return;
            }
            if (proposition > nbSecret)
            {
                label1.ForeColor = Color.Blue;
                label1.Text = "TROP GRAND !";
                label2.Text = "il reste : " + cpt + "Tentatives" ; 
            }
            else if (proposition < nbSecret)
            {
                label1.ForeColor = Color.Blue;
                label1.Text = "TROP PETIT !";
                label2.Text = "il reste : " + cpt + "Tentatives" ;
            }
            else gagne = true; // GAGNE
            cpt--;
            if (gagne)
            {
                label1.ForeColor = Color.Green;
                label1.Text = "GAGNE !";
                button1.Enabled = false;
                button2.Visible = true;
            }
            else if (cpt == 0)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "PERDU !";
                button1.Enabled = false;
                button2.Visible = true;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            Random r = new Random();
            nbSecret = r.Next(0, 100);
            this.Text = nbSecret.ToString();

            this.cpt = 6;
            this.gagne = false;
 
            button2.Visible = false;
            button1.Enabled = true;
            textBox1.Text = "";
        }
    }
}
