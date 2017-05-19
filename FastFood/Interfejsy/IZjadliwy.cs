using FastFood.Sklep;

namespace FastFood.Interfejsy
{
    public interface IZjadliwy
    {
        float Kalorie { get; }
        SwiezoscProduktu Swiezosc { get; }
        bool Zjedzony { get; }
        void Zjedz();
    }
}