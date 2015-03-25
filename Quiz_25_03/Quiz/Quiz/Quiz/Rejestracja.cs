using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Rejestracja : Form
    {
       // private bazaQuizDataContext bazaDC;
        
        Haszowanie hash = new Haszowanie();
        private Uzytkownicy osoba;
        bazaQuizDataContext bazaDC = new bazaQuizDataContext();
        public Rejestracja()
        {
            InitializeComponent();
            noweHaslo.PasswordChar = '*';
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
           if (osoba == null)
            {
                osoba = new Uzytkownicy();
                bazaDC.Uzytkownicies.InsertOnSubmit(osoba);
            }
            osoba.user_name = nowyUzytkownik.Text;
            osoba.password = hash.SzyfrujMD5(noweHaslo.Text);
            if(adminCB.Checked)
            {
                osoba.czy_admin = 1;
            }
                      
            bazaDC.SubmitChanges();
            Close();
        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }
        }
    }

