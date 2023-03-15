using System;

namespace Alessio.Exerses.Alternative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Continente continente;
            continente = new Continente("europa");
            continente.CreaPaese("italia");
            continente.PaeseCreaRegione("lazio");
            continente.RegioneCreaProvincia("viterbo");
            continente.ProvinciaCreaComune("Montefiascone");
        }
    }
}
