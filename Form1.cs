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
    public partial class Cos_Form : Form
    {
        public Cos_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Rejestracja_Button_Click(object sender, EventArgs e)
        {
           Rejestracja rejestracja = new Rejestracja();
            if (PowtorzHaslo_TextBox.Text == Haslo_TextBox.Text)
            {
                rejestracja.RejestracjaUzytkownika(User1_TextBox.Text, Haslo_TextBox.Text);
                MessageBox.Show("Rejestracja Pomyślna");
            }
            else
            {

                MessageBox.Show("Podałes błędne hasło");

            }
            


        }

        private void Wyjscie_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
