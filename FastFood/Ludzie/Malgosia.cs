using System;
using System.Collections.Generic;
using FastFood.Interfejsy;
using FastFood.Ludzie.Role;
using FastFood.Sklep;
using FastFood.Sklep.Sprzedaz;
using FastFood.Wyjatki;

namespace FastFood.Ludzie
{
    public class Malgosia : Czlowiek, INiania, IPiekarz, IStudent, ISprzedawca
    {
        public Malgosia() : base("Malgosia")
        {
            Energia = 50;
        }

        public double PoliczCeny(IEnumerable<IProdukt> listaZakupow)
        {
            double suma = 0;
            foreach (IProdukt produkt in listaZakupow)
            {
                suma += produkt.Cena;
            }
            return suma;
        }

        public double ZwrocReszte(double kwota, double doZaplaty)
        {
            Random random = new Random();
            return random.Next(0, (int)((kwota - doZaplaty) * 100)) / 100;
        }


        public Pakunek WydajProdukty(Zamowienie zamowienie)
        {
            if (!zamowienie.Zaplacone)
                throw new NieZaplaconoZaProduktyException();
            if (zamowienie.ZabranoProdukty)
                throw new ProduktyZostalyJuzZabraneException();
            List<IProdukt> produkty = zamowienie.Finalizuj();
            return new Pakunek(produkty);
        }

        public void ZaczepiajLudziNaKrakowskimPo22()
        {
            // ...
        }
    }
}