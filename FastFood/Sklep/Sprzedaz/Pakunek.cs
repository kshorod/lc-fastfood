using System.Collections.Generic;
using FastFood.Interfejsy;

namespace FastFood.Sklep.Sprzedaz
{
    public class Pakunek
    {
        public Pakunek(List<IProdukt> listaZakupow)
        {
            Zawartosc = listaZakupow;
        }
        public List<IProdukt> Zawartosc { get; private set; }

    }
}