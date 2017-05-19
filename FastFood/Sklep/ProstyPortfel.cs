using System;
using FastFood.Interfejsy;
using FastFood.Wyjatki;

namespace FastFood.Sklep
{
    public class ProstyPortfel : IPortfel
    {
        public ProstyPortfel()
        {
            _zawartosc = 0;

        }
        private double _zawartosc;
        public void Umiesc(double kwota)
        {
            _zawartosc += kwota;
        }

        public double WezMinimum(double kwota)
        {
            var sufit = Math.Ceiling(kwota);
            if (sufit > _zawartosc) throw new BrakujePieniedzyWPortfeluException();
            _zawartosc -= sufit;
            return sufit;
        }
    }
}