using System.Collections.Generic;
using FastFood.Interfejsy;
using FastFood.Sklep;
using FastFood.Sklep.Sprzedaz;

namespace FastFood.Ludzie.Role
{
    public interface ISprzedawca
    {
        double PoliczCeny(IEnumerable<IProdukt> listaZakupow);
        double ZwrocReszte(double kwota, double doZaplaty);
        Pakunek WydajProdukty(Zamowienie zamowienie);
    }
}