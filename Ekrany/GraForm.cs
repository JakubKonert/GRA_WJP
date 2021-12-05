using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using GRA_WJP.Klasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class GraForm : Form, IEkran
    {
        private Form _parent;
        public GraForm(Form parent)
        {
            Gra.ResetGra();
            _parent = parent;
            InitializeComponent();
            OdswiezEkran();
            parent.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Dom_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Dom);
        }

        private void Kopalnia_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Kopalnia);
        }

        private void Tartak_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Tartak);
        }

        private void Farma_Click(object sender, EventArgs e)
        {
            Gra.WyswietlBudynek(this, BudynekEnum.Farma);
        }

        private void Jedzenie_Click(object sender, EventArgs e)
        {
            Gra.WyswietlSurowiec(this, SurowiecEnum.Jedzenie);
        }

        private void Drewno_Click(object sender, EventArgs e)
        {

            Gra.WyswietlSurowiec(this, SurowiecEnum.Drewno);
        }

        private void Zloto_Click(object sender, EventArgs e)
        {
            Gra.WyswietlSurowiec(this, SurowiecEnum.Zloto);
        }

        //odswieżanie ekranu, co każdą czynność gracza
        public void OdswiezEkran()
        {
            Jedzenie.Text = $"{SurowiecEnum.Jedzenie}:\n {Gra.IloscSurowca(SurowiecEnum.Jedzenie)} / {Gra.MaksSurowca(BudynekEnum.Farma)}";
            Drewno.Text = $"{SurowiecEnum.Drewno}:\n {Gra.IloscSurowca(SurowiecEnum.Drewno)} / {Gra.MaksSurowca(BudynekEnum.Tartak)}";
            Zloto.Text = $"{SurowiecEnum.Zloto}:\n {Gra.IloscSurowca(SurowiecEnum.Zloto)} / {Gra.MaksSurowca(BudynekEnum.Kopalnia)}";
            Populacja.Text = $"Populacja:\n {Gra.IleDostepnaPopulacja()} / {Gra.IlePopulacja()} / {Gra.MaksSurowca(BudynekEnum.Dom)}";
            Tura.Text = $"Tura: \n {Gra.ktoraTura()} / {Gra.ilemaxTur()}";
        }

        private void Koniec_tury_Click(object sender, EventArgs e)
        {
            if (Gra.NastepnaTura())
                new Podsumowanie_tury(this).ShowDialog();
            else
            {
               this.Close();
               new Koniec(_parent).ShowDialog();
            }
        }
    }
}
