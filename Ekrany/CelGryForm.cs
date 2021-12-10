using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    public partial class CelGryForm : Form
    {
        private Form OknoRodzic;
        public CelGryForm(Form OknoRodzic)
        {
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();
            //opis slowny gry, wpisany prosto w kod aby niepotrzebnie nie kombinowac, a tylko zaznajomic
            //gracza na czym w ogole polega gra
            OpisLabel.Text = "Cel Gry:\n Witaj Graczu. Przed tobą stoi wyzwanie zarządzania wioską i " +
                "osiągnięcie tytułowej 1000 populacji, ale uważaj \n co raz bardziej rozwijająca się osada " +
                " będzie pochłaniać co raz większe ilości jedzenia oraz będzie większą \n ilość drewna zużywać" +
                "na opał. Aby temu przeciwdziałać, musisz rozsądnie dysponować ludźmi i przydzielać ich \n do " +
                "odpowiednich budynków. Ponadto, czekają na ciebie różne nieprzewidziane smutne wydarzenia, " +
                "które mają\n za zadanie utrudnić ci jeszcze bardziej osiągnięcie wymaganego celu.\n" +
                "\nParę zdań o grze: \n\n 1. Na osiągnięcie celu masz 50 Tur. \n\n 2. Po włączeniu gry, w górnej " +
                "części ekranu zobaczysz panel. Pozycje \"Jedzenie\",\"Drewno\" i \"Złoto\" to przyciski,\n" +
                "po których wciśnięciu możesz wyznaczyć wybraną liczbę ludzi do zbierania danego surowca.\n" +
                " \n 3. Opisy na górnym panelu oznaczają aktualną liczbę surowca na aktualnie maksymalną pojemność" +
                "\nnp. Jedzenie: 100/200 oznacza, że posiadasz 100 jednostek jedzenia, a twoja maksymalna pojemność" +
                "na farmie,\ndo przechowywania pożywnienia, jest równa 200.\n \n 4. W przypadku Populacji, jest podział" +
                " na 3 sekcje i oznaczają one odpowiednio: ilość dostępnej populacji \n(nie pracująca w żadnym " +
                "z dostępnych budynków) / aktualna populacja / maksymalna ilosc jaką można\n pomieścić na danym poziomie " +
                "domu.\n\n 5. Po wciśnięciu jednego z dostępnych budynków, możesz podejżeć jego statystki oraz możesz" +
                " go ulepszyć, \njeśli posiadasz odpowiednią ilość wymaganych surowców. \n \n 6. Po skończeniu swoich działań" +
                "w danej turze, klikarz przycisk \"Następna Tura\", aby przejść do następnej tury\ni otrzymać surowce " +
                "oraz nowych ludzi do pracy.";
        }

        private void PowrotMenuButton_Click(object sender, EventArgs e)
        {
            OknoRodzic.Visible = true;
            this.Close();
        }
    }
}
