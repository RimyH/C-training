using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlipFlop
{
    public partial class Form1 : Form
    {

        //Image image = Image.FromFile(".\\image\\darwin.jpg");
        //Image image1 = Image.FromFile(".\\image\\galilee.jpg");
        Image img;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile(".\\image\\darwin.jpg");
            Image image1 = Image.FromFile(".\\image\\galilee.jpg");
            //image.Width;
            pictureBox2.Image = image1;
            pictureBox1.Image = image;
            label1.Text = "";
            label1.ForeColor = Color.Red;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            img= pictureBox1.Image;
            
            pictureBox1.Image = pictureBox2.Image;

            pictureBox2.Image = img;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1_Click(sender,e);
            DialogResult reponse= MessageBox.Show(
                "erreur !",
                "titre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign
                 
                );
            if (reponse == DialogResult.Yes)
                label1.Text = "il a clicker sur yes";
            else if (reponse == DialogResult.No)
                label1.Text = "il a clicker sur NO";
            


        }

        /* private void pictureBox2_Click(object sender, EventArgs e)
         {


             img = pictureBox2.Image;

             pictureBox2.Image = pictureBox1.Image;

             pictureBox1.Image = img;




         }
        */
    }
}
