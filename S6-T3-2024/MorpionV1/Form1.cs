using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorpionV1
{
    public partial class Form1 : Form
    {
        private Button [,] grille;
        private String joueur;
        private int cpt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = ""; 
            button10.Text = "REJOUER?";
            button10.Visible = false;
            label1.Text = "";

            grille = new Button[3, 3];
            grille[0, 0] = button1;
            grille[0, 1] = button2;
            grille[0, 2] = button3;
            grille[1, 0] = button4;
            grille[1, 1] = button5;
            grille[1, 2] = button6;
            grille[2, 0] = button7;
            grille[2, 1] = button8;
            grille[2, 2] = button9;

            joueur = "X";
            cpt = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                cpt++;

                Button b = (Button)sender;
                //Button b = sender as Button;
                b.Text = joueur;
                b.Enabled = false;
                if (AnalyseGrille())
                {
                    label1.Text = "BRAVO " + joueur;
                    button10.Visible = true;
                    for (int l = 0; l < 3; l++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            grille[l, c].Enabled = false;
                        }
                    }
                }
                else
                {
                    if (cpt == 9)
                    {
                        label1.Text = "MATCH NUL !";
                        button10.Visible = true;
                    }
                }

                if (joueur.Equals("X")) joueur = "O";
                else joueur = "X";

            }


        }
        private bool AnalyseGrille()
        {
            String s;
            // Analyse Ligne 0
            s = "";
            for (int c=0; c<3;c++) s += grille[0, c].Text;
            if (s.Equals("XXX") || s.Equals("OOO")) return true;
            // Analyse Ligne 1
            s = "";
            for (int c = 0; c < 3; c++) s += grille[1, c].Text;
            if (s.Equals("XXX") || s.Equals("OOO")) return true;
            // Analyse Ligne 2
            s = "";
            for (int c = 0; c < 3; c++) s += grille[2, c].Text;
            if (s.Equals("XXX") || s.Equals("OOO")) return true;
            // Analyse Colonne 0
            s = "";
            for (int l = 0; l < 3; l++) s += grille[l,0].Text;
            if (s.Equals("XXX") || s.Equals("OOO")) return true;
            // Analyse Colonne 1
            s = "";
            for (int l = 0; l < 3; l++) s += grille[l, 1].Text;
            if (s.Equals("XXX") || s.Equals("OOO")) return true;
            // Analyse Colonne 2
            s = "";
            for (int l = 0; l < 3; l++) s += grille[l, 2].Text;
            if (s.Equals("XXX") || s.Equals("OOO")) return true;
            // Analyse Diagonale Gauche/Droite
            s = "";
            for (int l = 0; l < 3; l++) s += grille[l, l].Text;
            if (s.Equals("XXX") || s.Equals("OOO")) return true;
            // Analyse Diagonale Droite/Gauche
            s = "";
            for (int l = 0; l < 3; l++) s += grille[2-l, l].Text;
            if (s.Equals("XXX") || s.Equals("OOO")) return true;

            return false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button10.Visible = false;
            label1.Text = "";



            joueur = "X";
            cpt = 0;

            for (int l=0; l<3; l++)
            {
                for (int c=0; c<3; c++)
                {
                    grille[l, c].Enabled = true;
                }
            }
        }
    }
}
