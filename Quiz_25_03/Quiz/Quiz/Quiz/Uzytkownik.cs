﻿using System;
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
    public partial class Uzytkownik : Form
    {
        bazaQuizDataContext uzytkownikDB = new bazaQuizDataContext();
        public Uzytkownik()
        {
            InitializeComponent();
            foreach (Uzytkownicy u in uzytkownikDB.Uzytkownicies) // pobiera z tabeli zarejestrowanych uzytkownikow
            {
                obszar.AppendText("User name: " + u.user_name +" Hasl: " + u.password +"\n");
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Uzytkownik_Load(object sender, EventArgs e)
        {

        }
    }
}
