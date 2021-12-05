using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    public class Kopalnia : IBudynek
    {
        public Kopalnia(int lvl, int pojemnosc, int pojemonscLVL, int wspolczynnikUlepszeniaGlowny,
            String nazwaSurowcaGlowna)
        {
            this.lvl = lvl;
            this.pojemnosc = pojemnosc;
            this.nazwa = BudynekEnum.Kopalnia;
            this.wspolczynnikUlepszeniaGlowny = wspolczynnikUlepszeniaGlowny;
            this.pojemonscLVL = pojemonscLVL;

            this.nazwaSurowcaGlowna = nazwaSurowcaGlowna;
        }

        public int lvl { get; set; }
        public int pojemnosc { get; set; }
        public BudynekEnum nazwa { get; set; }

        public int wspolczynnikUlepszeniaGlowny { get; set; }
        public int wspolczynnikUlepszeniaPoboczny { get; set; }
        public String nazwaSurowcaGlowna { get; set; }
        public String nazwaSurowcaPoboczna { get; set; }
        public int pojemonscLVL { get; set; }

        public void Upgrade()
        {
            if (lvl >= 5)
                return;
          
            Gra.OdejmijSurowiec(SurowiecEnum.Zloto, lvl * wspolczynnikUlepszeniaGlowny);
            pojemnosc += pojemonscLVL;
            lvl++;
       
        }
        //funkcja, która sprawdza czy w ogóle gracza stać na ulepszenie budynku.
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Zloto) - (lvl * wspolczynnikUlepszeniaGlowny) >= 0);
    }
}
