using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    public class Dom : IBudynek
    {
        public Dom(int Lvl, int Pojemnosc, int PojemnoscLvl,
            int WspolczynnikUlepszeniaGlowny, int WspolczynnikUlepszeniaPoboczny,
            String NazwaSurowcaGlowna, String NazwaSurowcaPoboczna)
        {
            this.Lvl = Lvl;
            this.Pojemnosc = Pojemnosc;
            this.Nazwa = BudynekEnum.Dom;
            this.WspolczynnikUlepszeniaGlowny = WspolczynnikUlepszeniaGlowny;
            this.WspolczynnikUlepszeniaPoboczny = WspolczynnikUlepszeniaPoboczny;
            this.PojemnoscLvl = PojemnoscLvl;
            this.NazwaSurowcaGlowna = NazwaSurowcaGlowna;
            this.NazwaSurowcaPoboczna = NazwaSurowcaPoboczna;
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

            Gra.OdejmijSurowiec(SurowiecEnum.Drewno, Lvl * WspolczynnikUlepszeniaGlowny);
            Gra.OdejmijSurowiec(SurowiecEnum.Jedzenie, Lvl * WspolczynnikUlepszeniaPoboczny);
            Pojemnosc += PojemnoscLvl;
            Lvl++;
        }
        //funkcja sprawdza czy upgrade jest w ogole dostepny, a tym samym mozliwy dla gracza
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Drewno) - (Lvl * WspolczynnikUlepszeniaGlowny) >= 0)
            && (Gra.IloscSurowca(SurowiecEnum.Jedzenie) - (Lvl * WspolczynnikUlepszeniaPoboczny) >= 0);
    }
}
