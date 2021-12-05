using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Ekrany.Interfejsy
{
    public interface IBudynek
    {
        int lvl { get; set; }
        int pojemnosc { get; set; }
        BudynekEnum nazwa { get; set; }

        int wspolczynnikUlepszeniaPoboczny { get; set; }
        int wspolczynnikUlepszeniaGlowny { get; set; }
        int pojemonscLVL { get; set; }
        String nazwaSurowcaGlowna { get; set; }
        String nazwaSurowcaPoboczna { get; set; }
        void Upgrade();
        bool MowliwoscUpgradu();
    }
}
