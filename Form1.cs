using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weiss_Jessica_Tippspiel
{
    public partial class txtBox_Tipp1 : Form
    {
        //Defaultwerte
        private 

        //Variablen definieren
        decimal Einsatz = 0;
        int Tipp1 = 0;
        int Tipp2 = 0;
        int Ergebnis1 = 0;
        int Ergebnis2 = 0;
        int multiplikator = 0;
        int SiegerTipp = 0;
        int SiegerErgebnis = 0;
        decimal Gewinn = 0;


        public txtBox_Tipp1()
        {
            InitializeComponent();
        }

        private void txtBoxEinsatz_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGewinnertmitteln_Click(object sender, EventArgs e)
        {
            txtBoxEinsatz.BackColor = Color.White;
            txtBoxTipp1.BackColor = Color.White;
            txtBoxTipp2.BackColor = Color.White;
            txtBoxErgebnis1.BackColor = Color.White;
            txtBoxErgebnis2.BackColor = Color.White;
            lblIhrGewinn.Text = "";

            //Eingabekontrolle 
            //für Einsatz
            if (decimal.TryParse(txtBoxEinsatz.Text, out Einsatz) == false)
            { 
            lblIhrGewinn.Text = "Geben Sie bitte eine Dezimalzahl ein.";
            txtBoxEinsatz.BackColor = Color.Red;
            txtBoxEinsatz.Focus();
            txtBoxEinsatz.Text = "";
            return;
            }

            //für Tipp 1 + 2
            if (int.TryParse(txtBoxTipp1.Text, out Tipp1) == false)
            {
                lblIhrGewinn.Text = "Geben Sie bitte eine ganze Zahl ein.";
                txtBoxTipp1.BackColor = Color.Red;
                txtBoxTipp1.Focus();
                txtBoxTipp1.Text = "";
                return;
            }
           
            if (int.TryParse(txtBoxTipp2.Text, out Tipp2) == false)
            {
                lblIhrGewinn.Text = "Geben Sie bitte eine ganze Zahl ein.";
                txtBoxTipp2.BackColor = Color.Red;
                txtBoxTipp2.Focus();
                txtBoxTipp2.Text = "";
                return;
            }

            //für Ergebnis 1 + 2
            if (int.TryParse(txtBoxErgebnis1.Text, out Ergebnis1) == false)
            {
                lblIhrGewinn.Text = "Geben Sie bitte eine ganze Zahl ein.";
                txtBoxErgebnis1.BackColor = Color.Red;
                txtBoxErgebnis1.Focus();
                txtBoxErgebnis1.Text = "";
                return;
            }

            if (int.TryParse(txtBoxErgebnis2.Text, out Ergebnis2) == false)
            {
                lblIhrGewinn.Text = "Geben Sie bitte eine ganze Zahl ein.";
                txtBoxErgebnis2.BackColor = Color.Red;
                txtBoxErgebnis2.Focus();
                txtBoxErgebnis2.Text = "";
                return;
            }

            //Sieger von Tipp auswerten
            if(Tipp1 > Tipp2)
            {
                SiegerTipp = 1;
            }

            else if(Tipp1 < Tipp2)
            {
                SiegerTipp = 2;
            }

            else
            {
                SiegerTipp = 0;
            }

            //Sieger von Ergebnis auswerten
            if(Ergebnis1 > Ergebnis2)
            {
                SiegerErgebnis = 1;
            }

            else if(Ergebnis1 < Ergebnis2) 
            {
                SiegerErgebnis = 2;
            }

            else
            {
                SiegerErgebnis = 0;
            }

            //richtiger Tipp
            if (Tipp1 == Ergebnis1 && Tipp2 == Ergebnis2)
            {
                multiplikator = 5;
                Gewinn = Einsatz * multiplikator;
                lblIhrGewinn.Text = "Ihr Gewinn:" + Gewinn;
            }

            else if(Tipp1 - Tipp2 == Ergebnis1 - Ergebnis2)
            {
                multiplikator = 3;
                Gewinn = Einsatz * multiplikator;
                lblIhrGewinn.Text = "Ihr Gewinn:" + Gewinn;
            }

            else if(SiegerTipp == SiegerErgebnis)
            {
                multiplikator = 1;
                Gewinn = Einsatz * multiplikator;
                lblIhrGewinn.Text = "Ihr Gewinn:" + Gewinn;
            }


            else
            {
                multiplikator = 0;
                Gewinn = Einsatz * multiplikator;
                lblIhrGewinn.Text = "Leider nichts gewonnen!";
            }

        }
    }
}
