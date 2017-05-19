using FastFood.Interfejsy;
using FastFood.Ludzie.Role;

namespace FastFood.Ludzie
{
    public class Jasio : Czlowiek, IStudent
    {
        public Jasio() : base("Jasio")
        {
            Energia = 100;
            Portfel.Umiesc(50);
        }

        public override void Jedz(IZjadliwy zjadliwy)
        {
            Mlaskaj();
            zjadliwy.Zjedz();
            Energia += (int)zjadliwy.Kalorie / 50;
        }

        protected void Mlaskaj()
        {
            // wydaj dzwieki mlaskania...
        }
    }
}