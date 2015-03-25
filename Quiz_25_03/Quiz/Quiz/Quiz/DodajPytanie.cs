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
    public partial class DodajPytanie : Form
    {
        private Pytania pytanie;
        private Typ_pytania typ;
        private Kategoria kategoria;
        private Odpowiedzi odp_1,odp_2,odp_3,odp_4;
        bazaQuizDataContext bazaDC = new bazaQuizDataContext();
        public DodajPytanie()
        {
            InitializeComponent();
        }

        private void zapiszPytanie_Click(object sender, EventArgs e)
        {
            
            if (pytanie == null)
            {
                pytanie = new Pytania();
                bazaDC.Pytanias.InsertOnSubmit(pytanie);
            }
            pytanie.tresc = tresc.Text;

            if (typ == null)
            {
                typ = new Typ_pytania();
                bazaDC.Typ_pytanias.InsertOnSubmit(typ);
            }
            //typ.poziom = Convert.ToInt32(poziomPytania.Text);
            typ.poziom = Convert.ToInt32(numericUpDown.Text);
            
            if (kategoria == null)
            {
                kategoria = new Kategoria();
                bazaDC.Kategorias.InsertOnSubmit(kategoria);
            }
            kategoria.nazwa = kategoriaPytania.Text;
           
            //odpowiedz 1
            { 
                if (odp_1 == null)
                {
                    odp_1 = new Odpowiedzi();
                    bazaDC.Odpowiedzis.InsertOnSubmit(odp_1);
                }
                if (czyDobraOdp1.Checked)
                {
                    odp_1.czy_poprawna = 1;
                }
                else
                {
                    odp_1.czy_poprawna = 0;
                }
                odp_1.odp = odp1.Text;
            }

            //odpowiedz 2
            {
                if (odp_2 == null)
                {
                    odp_2 = new Odpowiedzi();
                    bazaDC.Odpowiedzis.InsertOnSubmit(odp_2);
                }
                if (czyDobraOdp2.Checked)
                {
                    odp_2.czy_poprawna = 1;
                }
                else
                {
                    odp_2.czy_poprawna = 0;
                }
                odp_2.odp = odp1.Text;
            }

            //odpowiedz 3
            {
                if (odp_3 == null)
                {
                    odp_3 = new Odpowiedzi();
                    bazaDC.Odpowiedzis.InsertOnSubmit(odp_3);
                }
                if (czyDobraOdp3.Checked)
                {
                    odp_3.czy_poprawna = 1;
                }
                else
                {
                    odp_3.czy_poprawna = 0;
                }
                odp_3.odp = odp1.Text;
            }

            //odpowiedz 4
            {
                if (odp_4 == null)
                {
                    odp_4 = new Odpowiedzi();
                    bazaDC.Odpowiedzis.InsertOnSubmit(odp_4);
                }
                if (czyDobraOdp4.Checked)
                {
                    odp_4.czy_poprawna = 1;
                }
                else
                {
                    odp_4.czy_poprawna = 0;
                }
                odp_4.odp = odp1.Text;
            }
            if (czyDobraOdp1.Checked || czyDobraOdp2.Checked || czyDobraOdp3.Checked || czyDobraOdp4.Checked)
            {
                bazaDC.SubmitChanges();
                Close();
            }
            else
            {
                MessageBox.Show("Nie zaznaczyles zadnej poprawnej odpowiedzi.");
            }

            
        }

        private void DodajPytanie_Load(object sender, EventArgs e)
        {

        }
    }
}
