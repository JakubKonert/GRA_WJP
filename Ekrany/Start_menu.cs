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
    public partial class Start_menu : Form
    {
        public Start_menu()
        {
            InitializeComponent();
        }

        private void Wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_gry_Click(object sender, EventArgs e)
        {
            new GraForm(this).ShowDialog();
        }

        private void Cel_gry_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new CelGryForm().ShowDialog();
        }

        private void Statystyki_start_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new StatystykiForm().ShowDialog();
        }
    }
}
