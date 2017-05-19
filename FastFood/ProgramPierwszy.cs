using System.Collections.Generic;
using FastFood.Interfejsy;
using FastFood.Sklep.Produkty;

namespace FastFood
{
    public class ProgramPierwszy
    {
        static void Main2()
        {
            List<IProdukt> listaZakupow = new List<IProdukt>();
            double portfel = 20;

            listaZakupow.Add(new Burger("Big Mac", 5.99, 120));
            listaZakupow.Add(new CocaCola(3.99));
            listaZakupow.Add(new Frytki(2.99));

            double cena = 0;
            foreach (IProdukt produkt in listaZakupow)
            {
                cena += produkt.Cena;
            }

            portfel = portfel - cena;

            foreach (IProdukt produkt in listaZakupow)
            {
                IZjadliwy zjadliwy = produkt as IZjadliwy;
                if (zjadliwy != null)
                {
                    zjadliwy.Zjedz();
                }
            }
        }
    }
}