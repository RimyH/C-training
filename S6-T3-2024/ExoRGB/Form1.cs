using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExoRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void trackBar3_Scroll(object sender, EventArgs e)
        {

            trackBar3.Minimum = 0;
            trackBar3.Maximum = 255;

           this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            // Mettre à jour la TextBox correspondante
            textBox3.Text = trackBar3.Value.ToString();




        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 255;
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            textBox1.Text = trackBar1.Value.ToString();

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            trackBar2.Minimum = 0;
            trackBar2.Maximum = 255;
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            textBox2.Text = trackBar2.Value.ToString();

        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Red;
            label2.BackColor= Color.Green;
            label3.BackColor= Color.Blue;

            // Initialiser les valeurs des TextBox avec les valeurs des TrackBars
            textBox1.Text = trackBar1.Value.ToString();
            textBox2.Text = trackBar2.Value.ToString();
            textBox3.Text = trackBar3.Value.ToString();

           



        }

       



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, out value) && value >= 0 && value <= 255)
            {
                // Mettre à jour la valeur de la TrackBar en fonction du contenu de la TextBox
                trackBar1.Value = value;


                // Mettre à jour la couleur de fond du formulaire
                this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            }
            else if (value>=255)
            {
                DialogResult reponse = MessageBox.Show(
                 "Erreur il faut taper un nulero ente 0 et 255 ",
                 "Erreur",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign);

                textBox1.Text = "";

            }




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


            int value;
            


            if (int.TryParse(textBox2.Text, out value) && value >= 0 && value <= 255)
            {
                // Mettre à jour la valeur de la TrackBar en fonction du contenu de la TextBox
                trackBar2.Value = value;

                // Mettre à jour la couleur de fond du formulaire
                this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            }
            else if (value >= 255)
            {
                DialogResult reponse = MessageBox.Show(
                 "Erreur il faut taper un nulero ente 0 et 255 ",
                 "Erreur",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign);
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            int value;
           

            if (int.TryParse(textBox3.Text, out value) && value >= 0 && value <= 255)
                        {
                            // Mettre à jour la valeur de la TrackBar en fonction du contenu de la TextBox
                            trackBar3.Value = value;

                            // Mettre à jour la couleur de fond du formulaire
                            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
                        }
            else if(value >= 255)
            {
                DialogResult reponse = MessageBox.Show(
                 "Erreur il faut taper un nulero ente 0 et 255 ",
                 "Erreur",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error,
                 MessageBoxDefaultButton.Button1,
                 MessageBoxOptions.RightAlign);
                textBox3.Text = "";

            }


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return; /// supp

            if (!char.IsDigit(e.KeyChar)) // si pas de cara
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return; /// supp

            if (!char.IsDigit(e.KeyChar)) // si pas de cara
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back) return; /// supp

            if (!char.IsDigit(e.KeyChar)) // si pas de cara
                e.Handled = true;

        }
    }
}
