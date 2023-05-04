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
            continente.PaeseCreaRegione("Umbria");
            continente.RegioneCreaProvincia("viterbo");
            continente.ProvinciaCreaComune("Montefiascone");
            //////Cambio
            continente.PaeseCambiaRegione("Lombardia", "italia", "Austria");
            continente.RegioneCambiaProvincia("Terni","Lazio","Umbria","italia");
            continente.ProvinciaCambiaComune("Montefiascone","viterbo","Chieti","Umbria","italia");
        }
    }
}
