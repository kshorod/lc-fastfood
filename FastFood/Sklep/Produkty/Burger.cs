using FastFood.Interfejsy;
using FastFood.Wyjatki;

namespace FastFood.Sklep.Produkty
{
    public class Burger : IProdukt, IZjadliwy
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }
        public float Kalorie { get; set; }
        public SwiezoscProduktu Swiezosc { get; set; }
        public bool Zjedzony { get; private set; }

        public Burger(string nazwa, double cena, float kalorie)
        {
            Nazwa = nazwa;
            Cena = cena;
            Kalorie = kalorie;
            Swiezosc = SwiezoscProduktu.Swiezy;
        }

        public void Zjedz()
        {
            if(Zjedzony) throw new JuzZostalemZjedzonyException();
            Zjedzony = true;
        }
    }
}