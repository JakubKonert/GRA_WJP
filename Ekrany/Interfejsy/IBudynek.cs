using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Ekrany.Interfejsy
{
    /// <summary>
    /// Interfejs umożliwiający późniejsze stworzenie listy budynków, które po nim
    /// dziedziczą + stanowi przypominajkę co należy zawrzeć w klasie budynku, który
    /// po nim dziedziczy.
    /// </summary>
    public interface IBudynek
    {
        int lvl { get; set; }
        int pojemnosc { get; set; }
        BudynekEnum Nazwa { get; }
        int wspolczynnikUlepszeniaPoboczny { get; }
        int wspolczynnikUlepszeniaGlowny { get; }
        int pojemnoscLvl { get; set; }
        String NazwaSurowcaGlowna { get; }
        String NazwaSurowcaPoboczna { get; }
        void Upgrade();
        bool MowliwoscUpgradu();
    }
}
