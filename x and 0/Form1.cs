using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x_and_0
{
    public partial class Form1 : Form
    {

        bool turn = true;
        int turn_count = 0;
        int nr_castiguri_x = 0;
        int nr_castiguri_0 = 0;
        int nr_egal = 0;
        public Form1()
        {
            InitializeComponent();
        }


        



        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Joc x si 0 realizat de Gavrila Vladut");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                MessageBox.Show("Este Randul lui 0");
                b.Text = "X";
                b.BackColor = Color.Aqua;

            }
            else
            {
                MessageBox.Show("Este Randul lui X");
                b.Text = "0";
                b.BackColor =Color.Yellow;
            }

            turn = !turn;
            b.Enabled = false;
            turn_count++;
            verificarer();
        }

        private void verificarer()
        {

            int ok = 0;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && !A1.Enabled )
                ok = 1;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && !B1.Enabled)
                ok = 1;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && !C1.Enabled)
                ok = 1;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && !A1.Enabled)
                ok = 1;
            else if ((C1.Text == B2.Text) && (B2.Text == A3.Text) && !C1.Enabled)
                ok = 1;
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && !A1.Enabled)
                ok = 1;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && !A2.Enabled)
                ok = 1;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && !A3.Enabled)
                ok = 1;
            if (ok == 1)
            {
                disableButtons();
                String castiga = "";
                if (turn)
                {
                    castiga = "O";
                    nr_castiguri_0++;

                }
                else
                {
                    castiga = "X";
                    nr_castiguri_x++;
                }

                MessageBox.Show(castiga + " a castigat! Felicitari!     " +"\n "+ "Scorul acum este:      " + "\n " + "X:   " + nr_castiguri_x + " Victorii        " + "\n " + "0:    " + nr_castiguri_0 + " Victorii        " + "\n " + "=:      " + nr_egal + " Egal-uri        ", "Cineva a castigat!");
                turn = true;
                turn_count = 0;
                try
                {

                    {
                        foreach (Control c in Controls)
                        {
                            Button b = (Button)c;
                            b.Enabled = true;
                            b.Text = "";
                            b.BackColor = Color.White;
                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                if (turn_count == 9)
                {
                    nr_egal++;

                    MessageBox.Show("EGALITATE" + "\n " + "Scorul acum este:      " + "\n " + "X:   " + nr_castiguri_x + " Victorii        " + "\n " + "0:    " + nr_castiguri_0 + " Victorii        " + "\n " + "=:      " + nr_egal + " Egal-uri        ", "Egalitate");

                    turn = true;
                    turn_count = 0;
                    try
                    {

                        {
                            foreach (Control c in Controls)
                            {
                                Button b = (Button)c;
                                b.Enabled = true;
                                b.Text = "";
                                b.BackColor = Color.White;
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }

        }

        private void disableButtons()
        {
            try
            {

                {
                    foreach (Control c in Controls)
                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                }
            }
            catch 
            {

            }
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {

                {
                    foreach (Control c in Controls)
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                        b.BackColor = Color.White;
                    }
                }
            }
            catch
            {

            }
        }
    }
}
