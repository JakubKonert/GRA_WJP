using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Ekrany.Interfejsy
{
    //interfejs aby moc stworzyc liste budynkow, ktore dziedzicza po tym interfejsie
    //+ interfejs jako przypominajka co musze zawrzec w budynku
    public interface IBudynek
    {
        int Lvl { get; set; }
        int Pojemnosc { get; set; }
        BudynekEnum Nazwa { get; }
        int WspolczynnikUlepszeniaPoboczny { get; }
        int WspolczynnikUlepszeniaGlowny { get; }
        int PojemonscLVL { get; set; }
        String NazwaSurowcaGlowna { get; }
        String NazwaSurowcaPoboczna { get; }
        void Upgrade();
        bool MowliwoscUpgradu();
    }
}
