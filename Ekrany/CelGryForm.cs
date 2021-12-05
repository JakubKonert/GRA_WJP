using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class CelGryForm : Form
    {
        public CelGryForm()
        {
            InitializeComponent();
        }

        private void powrot_Menu_Click(object sender, EventArgs e)
        {
            //Pytanie: powrócenie widzialności menu głównego
            //Menu_form.visible = true;
            this.Close();
        }
    }
}
