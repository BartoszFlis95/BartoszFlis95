using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie5YT
{
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rejestracja_Button_Click(object sender, EventArgs e)
        {
            Cos_Form Cos = new Cos_Form();
            Cos.Show();
        }

        private void Logowanie_Button_Click(object sender, EventArgs e)
        {
            bool CzyDobryUzytkownik = false;
            


            BibliotekaUrzytkownik ListaUrzytkownikow = new BibliotekaUrzytkownik();
            ListaUrzytkownikow.UzytkownikDownload();
            foreach (Uzytkownik uzytkownik in ListaUrzytkownikow.lista)
            {


                if (Login1_TextBox.Text == uzytkownik.login && Haslo1_textbox.Text == uzytkownik.password)
                {

                    CzyDobryUzytkownik = true;
                }
                  
            }

            if (CzyDobryUzytkownik == true)
            {
                MessageBox.Show("ZALOGOWANO");

            }
            else
            {

                MessageBox.Show("NIE ZALOGOWANO");
            }

        }
        //Przybijam pieczatki dobrego programu!!! Elo



    }
}