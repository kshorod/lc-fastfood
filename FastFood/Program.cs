using System;
using FastFood.Interfejsy;
using FastFood.Ludzie;
using FastFood.Ludzie.Role;
using FastFood.Sklep;
using FastFood.Sklep.Sprzedaz;

namespace FastFood
{
    class Program
    {
    static void Main(string[] args)
    {
        Jasio jasio = new Jasio();
        ISprzedawca sprzedawca = new Malgosia();

        Console.WriteLine("Jasio ma w sobie {0} energii", jasio.Energia);

        Zamowienie zamowienie = new Zamowienie(sprzedawca);

        zamowienie.Kup(Menu.BigMac());
        zamowienie.Kup(Menu.Frytki());
        zamowienie.Kup(Menu.CocaCola());

        double doZaplaty = zamowienie.KwotaDoZaplaty();
        Console.WriteLine("Do zaplaty: {0}", doZaplaty);

        double reszta = zamowienie.Zaplac(jasio.Portfel.WezMinimum(doZaplaty));
        Console.WriteLine("Jasio otrzymal reszte {0}", reszta);
        jasio.Portfel.Umiesc(reszta);
        Pakunek pakunek = sprzedawca.WydajProdukty(zamowienie);

        foreach (var produkt in pakunek.Zawartosc)
        {
            var zjadliwy = produkt as IZjadliwy;
            if (zjadliwy != null)
            {
                Console.WriteLine("Jasio je {0} ktory ma {1} kalorii", produkt.Nazwa, zjadliwy.Kalorie);
                jasio.Jedz(zjadliwy);
            }
        }

        Console.WriteLine("Po jedzeniu Jasio ma w sobie {0} energii", jasio.Energia);
    }
    }
}
