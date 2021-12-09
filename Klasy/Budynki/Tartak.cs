using GRA_WJP.Ekrany.Interfejsy;
using GRA_WJP.Enums;
using System;

namespace GRA_WJP.Klasy.Budynki
{
    public class Tartak : IBudynek
    {
        public Tartak(int Lvl, int Pojemnosc, int PojemnoscLvl, int WspolczynnikUlepszeniaPoboczny,
            int WspolczynnikUlepszeniaGlowny,
            String NazwaSurowcaGlowna, String NazwaSurowcaPoboczna)
        {
            this.Lvl = Lvl;
            this.Pojemnosc = Pojemnosc;
            this.Nazwa = BudynekEnum.Tartak;
            this.WspolczynnikUlepszeniaPoboczny = WspolczynnikUlepszeniaPoboczny;
            this.WspolczynnikUlepszeniaGlowny = WspolczynnikUlepszeniaGlowny;
            this.PojemnoscLvl = PojemnoscLvl;

            this.NazwaSurowcaGlowna = NazwaSurowcaGlowna;
            this.NazwaSurowcaPoboczna = NazwaSurowcaPoboczna;
        }

        public int Lvl { get; set; }
        public int Pojemnosc { get; set; }
        public BudynekEnum Nazwa { get; }
        public String NazwaSurowcaGlowna { get; }
        public String NazwaSurowcaPoboczna { get; }
        public int WspolczynnikUlepszeniaPoboczny { get; }
        public int WspolczynnikUlepszeniaGlowny { get; }
        public int PojemnoscLvl { get; set; }

        //upgrade kosztuje surowce, wiec trzeba je odjac z konta gracza
        public void Upgrade()
        {
            if (Lvl >= 5)
                return;

            Gra.OdejmijSurowiec(SurowiecEnum.Zloto, Lvl * WspolczynnikUlepszeniaPoboczny);
            Gra.OdejmijSurowiec(SurowiecEnum.Drewno, Lvl * WspolczynnikUlepszeniaGlowny);
            Pojemnosc += PojemnoscLvl;
            Lvl++;
        }
        //aby upgrade byl mozlwiwy, trzeba spelnic wymagane warunki w ilosci surowca
        public bool MowliwoscUpgradu() => (Gra.IloscSurowca(SurowiecEnum.Zloto) - (Lvl * WspolczynnikUlepszeniaPoboczny) >= 0)
            && (Gra.IloscSurowca(SurowiecEnum.Drewno) - (Lvl * WspolczynnikUlepszeniaGlowny) >= 0);
    }
}
