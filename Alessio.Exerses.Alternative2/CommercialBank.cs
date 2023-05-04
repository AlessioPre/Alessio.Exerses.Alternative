using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alessio.Exerses.Alternative2
{
    internal class CommercialBank :IObserver
    {
        private CentralBank bank;
 
        private string name;
        private string CentralBankCEO;

        internal CentralBank Bank { get => bank; set => bank = value; }

        public CommercialBank(CentralBank bank, string v)
        {
            this.Bank = bank;
            this.name = v;
        }

        public void Update()
        {
            CentralBankCEO = Bank.Ceo;
            Console.WriteLine("Observer {0}'s new state is {1}",
               name, CentralBankCEO);
        }

    }
}
