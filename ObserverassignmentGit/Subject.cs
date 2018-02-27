using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Group 19
// Anni L.W.
// Emma P.J.
// Morten F.E.
namespace Observerassignment
{
    // Subject class that has the 3 needed methods and a list to contain observers
    // This subject class is used for the 1st observer pattern between stock and portfolio
    abstract class Subject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(Stock stockvalue)
        {
            foreach (var observer in _observers)
            {
                observer.Update(stockvalue);
            }
        }

    }
    
}
