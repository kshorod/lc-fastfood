using FastFood.Sklep.Produkty;

namespace FastFood.Sklep.Sprzedaz
{
    public class Menu
    {
        public static Burger BigMac()
        {
            return new Burger("Big Mac", 5.99, 257.2f);
        }

        public static Frytki Frytki()
        {
            return new Frytki(2.99);
        }

        public static CocaCola CocaCola()
        {
            return new CocaCola(4.99);
        }
    }
}