using FastFood.Interfejsy;
using FastFood.Sklep;

namespace FastFood.Ludzie
{
    public abstract class Czlowiek
    {
        public string Imie { get; }
        public int Energia { get; protected set; }
        public IPortfel Portfel { get; protected set; }

        protected Czlowiek(string imie)
        {
            Imie = imie;
            Portfel = new ProstyPortfel();
        }

        public virtual void Jedz(IZjadliwy zjadliwy)
        {
            zjadliwy.Zjedz();
            Energia += (int)zjadliwy.Kalorie / 100;
            if (zjadliwy.Swiezosc == SwiezoscProduktu.Nieswiezy)
            {
                BolBrzucha();
            }
        }

        private void BolBrzucha()
        {
            // Teraz boli mnie brzuch...
        }


    }
}