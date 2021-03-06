using System;
using System.Windows.Forms;

namespace GRA_WJP.Ekrany
{
    /// <summary>
    /// Okno, w którym po krótko jest opisane o co chodzi w grze oraz wytłumaczone jej główne
    /// funkcjonalności
    /// </summary>
    public partial class CelGryForm : Form
    {
        private Form OknoRodzic;
        public CelGryForm(Form OknoRodzic)
        {
            this.OknoRodzic = OknoRodzic;
            InitializeComponent();
            //Opis słowny gry, wpisany prosto w kod aby niepotrzebnie nie kombinowac, a tylko
            //zaznajomić gracza na czym w ogóle polega gra
            OpisLabel.Text = "Witaj Graczu. !\n\n" +
                "Przed tobą stoi wyzwanie zarządzania wioską i osiągnięcie tytułowej populacji, ale uważaj " +
                "coraz bardziej\nrozwijająca się osada będzie pochłaniać coraz większe ilości jedzenia oraz " +
                "coraz większą ilość drewna\nzużywać na opał. Aby temu przeciwdziałać, musisz rozsądnie dysponować" +
                " ludźmi i przydzielać ich do\nodpowiednich budynków. Ponadto, czekają na ciebie różne " +
                "nieprzewidziane smutne wydarzenia, które mają\nza zadanie utrudnić ci jeszcze bardziej " +
                "osiągnięcie wymaganego celu.\n\n" +
                "Cel Gry:   osiągnięcie populacji Twojej wioski na poziomie 1000 osób\n\n" +
                "Zasady gry:\n\n" +
                "1. Wygrana następuje po osiągnięciu 1000 populacji w dostępnym limicie tur.\n" +
                "2. Przegrana następuje gdy:\n" +
                "A: Nie osiągniesz 1000 populacji w dostępnym limicie tur.\n" +
                "B: Twoja żywność spadnie do 0. (Nie pozwół, aby ta wartość kiedykolwiek wystąpiła na koniec twojej rundy.)\n" +
                "C: Twoje drewno spadnie do 0. (Nie pozwół, aby ta wartość kiedykolwiek wystąpiła na koniec twojej rundy.)\n" +
                "2. Na osiągnięcie celu masz 50 Tur.\n" +
                "3.	Po włączeniu gry, w górnej części ekranu widnieje panel gry. Pozycje " +
                "\\  Jedzenie \\  Drewno \\ Złoto to\nprzyciski, po których wciśnięciu możesz wyznaczyć " +
                "wybraną liczbę ludzi do zbierania danego surowca.\n" +
                "4.	Opisy na górnym panelu oznaczają aktualną liczbę surowca oraz aktualnie maksymalną pojemność\n" +
                "magazynów w wiosce. Np. Jedzenie: 100/200 oznacza, że posiadasz 100 jednostek jedzenia, a twoja" +
                "\nmaksymalna pojemność na farmie, do przechowywania pożywienia, jest równa 200.\n" +
                "5.Pozycja  „Populacja”, jest podzielona na 3 sekcje i oznaczają one odpowiednio: ilość dostępnej" +
                " populacji\n(nie pracująca w żadnym z dostępnych budynków) / aktualna populacja / maksymalna " +
                "ilość jaką można\npomieścić na danym poziomie rozbudowy domu w wiosce.\n" +
                "6.	Po wciśnięciu jednego z dostępnych budynków, możesz podejrzeć jego statystki oraz możesz go ulepszyć,\n" +
                "jeśli posiadasz odpowiednią ilość wymaganych surowców.\n" +
                "7. Po skończeniu swoich działań w danej turze, wciskasz przycisk  „Następna Tura”,  aby przejść " +
                "do następnej\ntury i otrzymać surowce oraz nowych ludzi do pracy.\n" +
                "8. Wciśnięcie klawisza \"q\" na klawiaturze, powoduje wyskoczenie okienka \"Pauza Gry\".\n" +
                "Uwaga! Kliknięcie opcji \"Powrót do menu\" lub \"Wyjście z gry\" NIE powoduje zapisu stanu gry.\n\n" +
                "Powodzenia !!!";
        }
        /**Zamknięcie okna dotyczącego opisu gry*/
        private void PowrotMenuButton_Click(object sender, EventArgs e)
        {
            OknoRodzic.Visible = true;
            this.Close();
        }
    }
}
