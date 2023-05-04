using System;

namespace Alessio.Exerses.Alternative2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "mario";
            string surname= "mario";
            CentralBank bank = new CentralBank();

            bank.Add(new CommercialBank(bank,"mediolanum"));
            bank.Add(new CommercialBank(bank, "intesa"));
            string name2 = "maria";
            string surname2 = "maria";
            bank.ChangeCEO(name, surname);
            bank.Notify();

            bank.ChangeCEO(name2, surname2);
            bank.Notify();
        }
    }
}
