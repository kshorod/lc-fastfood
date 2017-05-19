using FastFood.Interfejsy;

namespace FastFood.Sklep.Produkty
{
    public class CocaCola : IProdukt
    {
        public string Nazwa { get; }
        public double Cena { get; }

        public CocaCola(double cena)
        {
            Nazwa = "Coca Cola";
            Cena = cena;
        }
    }
}