using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    public class Kopalnia : IBudynek
    {
        public Kopalnia(int Lvl, int Pojemnosc, int PojemnoscLvl , int WspolczynnikUlepszeniaGlowny,
            String NazwaSurowcaGlowna)
        {
            this.Lvl = Lvl;
            this.Pojemnosc = Pojemnosc;
            this.Nazwa = BudynekEnum.Kopalnia;
            this.WspolczynnikUlepszeniaGlowny = WspolczynnikUlepszeniaGlowny;
            this.PojemnoscLvl = PojemnoscLvl;
            this.NazwaSurowcaGlowna = NazwaSurowcaGlowna;
        }

        public int Lvl { get; set; }
        public int Pojemnosc { get; set; }
        public BudynekEnum Nazwa { get; set; }

        public int WspolczynnikUlepszeniaGlowny { get; set; }
        public int WspolczynnikUlepszeniaPoboczny { get; set; }
        public String NazwaSurowcaGlowna { get; set; }
        public String NazwaSurowcaPoboczna { get; set; }
        public int PojemnoscLvl { get; set; }

        //upgrade kosztuje surowce, wiec trzeba je odjac z konta gracza
        public void Upgrade()
        {
            if (Lvl >= 5)
                return;

            Gra.OdejmijSurowiec(SurowiecEnum.Zloto, Lvl * WspolczynnikUlepszeniaGlowny);
            Pojemnosc += PojemnoscLvl;
            Lvl++;
        }
        //funkcja, która sprawdza czy w ogóle gracza stać na ulepszenie budynku.
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Zloto) - (Lvl * WspolczynnikUlepszeniaGlowny) >= 0);
    }
}
