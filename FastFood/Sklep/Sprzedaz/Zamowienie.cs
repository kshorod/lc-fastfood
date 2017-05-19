using System.Collections.Generic;
using FastFood.Interfejsy;
using FastFood.Ludzie.Role;
using FastFood.Wyjatki;

namespace FastFood.Sklep.Sprzedaz
{
    public class Zamowienie
    {
        private readonly ISprzedawca _sprzedawca;

        public Zamowienie(ISprzedawca sprzedawca)
        {
            _sprzedawca = sprzedawca;
            _listaZakupow = new List<IProdukt>();
        }

        private List<IProdukt> _listaZakupow;
        public bool Zaplacone { get; private set; }
        public bool ZabranoProdukty { get; private set; }

        public double Kup(IProdukt produkt)
        {
            _listaZakupow.Add(produkt);
            return produkt.Cena;
        }

        public double KwotaDoZaplaty()
        {
            return _sprzedawca.PoliczCeny(_listaZakupow);
        }

        public double Zaplac(double kwota)
        {
            double doZaplaty = KwotaDoZaplaty();
            if (kwota < doZaplaty)
                throw new NieWystarczyloPieniedzyException();
            Zaplacone = true;
            return _sprzedawca.ZwrocReszte(kwota, doZaplaty);
        }

        public List<IProdukt> Finalizuj()
        {
            if (ZabranoProdukty) throw new ProduktyZostalyJuzZabraneException();
            ZabranoProdukty = true;
            return _listaZakupow;
        }
    }
}