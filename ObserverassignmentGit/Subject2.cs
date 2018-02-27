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
    // This subject class is used for the 2nd observer pattern between portfolio and portfoliodisplay
    abstract class Subject2
    {
        private readonly List<IObserver2> _observers = new List<IObserver2>();

        public void Attach(IObserver2 observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver2 observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(Portfolio portfolio)
        {
            foreach (var observer in _observers)
            {
                observer.Update(portfolio);
            }
        }

    }
}
