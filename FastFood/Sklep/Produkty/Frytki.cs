using FastFood.Interfejsy;

namespace FastFood.Sklep.Produkty
{
    public class Frytki : IProdukt
    {
        public string Nazwa { get; }
        public double Cena { get; }

        public Frytki(double cena)
        {
            Cena = cena;
            Nazwa = "Frytki";
        }
    }
}