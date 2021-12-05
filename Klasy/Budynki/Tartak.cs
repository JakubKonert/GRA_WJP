using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    public class Tartak : IBudynek
    {
        public Tartak(int lvl, int pojemnosc, int pojemonscLVL, int wspolczynnikUlepszeniaPoboczny,
            int wspolczynnikUlepszeniaGlowny,
            String nazwaSurowcaGlowna, String nazwaSurowcaPoboczna)
        {
            this.lvl = lvl;
            this.pojemnosc = pojemnosc;
            this.nazwa = BudynekEnum.Tartak;
            this.wspolczynnikUlepszeniaPoboczny = wspolczynnikUlepszeniaPoboczny;
            this.wspolczynnikUlepszeniaGlowny = wspolczynnikUlepszeniaGlowny;
            this.pojemonscLVL = pojemonscLVL;

            this.nazwaSurowcaGlowna = nazwaSurowcaGlowna;
            this.nazwaSurowcaPoboczna = nazwaSurowcaPoboczna;
        }

        public int lvl { get; set; }
        public int pojemnosc { get; set; }
        public BudynekEnum nazwa { get; set; }
        public String nazwaSurowcaGlowna { get; set; }
        public String nazwaSurowcaPoboczna { get; set; }

        public int wspolczynnikUlepszeniaPoboczny { get; set; }
        public int wspolczynnikUlepszeniaGlowny { get; set; }
        public int pojemonscLVL { get; set; }

        public void Upgrade()
        {
            if (lvl >= 5)
                return;

            Gra.OdejmijSurowiec(SurowiecEnum.Zloto, lvl * wspolczynnikUlepszeniaPoboczny);
            Gra.OdejmijSurowiec(SurowiecEnum.Drewno, lvl * wspolczynnikUlepszeniaGlowny);
            pojemnosc += pojemonscLVL;
            lvl++;
        }

        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Zloto) - (lvl * wspolczynnikUlepszeniaPoboczny) >= 0)
            && (Gra.IloscSurowca(SurowiecEnum.Drewno) - (lvl * wspolczynnikUlepszeniaGlowny) >= 0);
    }
}
