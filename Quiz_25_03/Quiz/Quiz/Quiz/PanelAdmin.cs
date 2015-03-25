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
    public partial class PanelAdmin : Form
    {
        
        public PanelAdmin()
        {
            InitializeComponent();
        }

        private void dodaj_pyt_Click(object sender, EventArgs e)
        {
            var Form = new DodajPytanie();
            Form.Show();
        }

        private void usun_uzyt_Click(object sender, EventArgs e)
        {
            var Form = new UsuwanieUzytkownika();
            Form.Show();
        }
        }
    }

