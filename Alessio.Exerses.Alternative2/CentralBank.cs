using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Alessio.Exerses.Alternative2
{
    internal class CentralBank:ISubject
    {
        private string _ceo = "senza Ceo";
        public CentralBank() { }
        List<IObserver> observers = new List<IObserver>();

        public string Ceo
        {
            get { return _ceo; }
            set
            {
                if (value != _ceo)
                {
                    _ceo = value;
                    Notify();
                }
            }
        }

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notify()
        {
            foreach (IObserver item in observers)
            {
                item.Update();
            }
        }

        internal void ChangeCEO(string name, string surname)
        {
            Ceo = name+ " " + surname;
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
