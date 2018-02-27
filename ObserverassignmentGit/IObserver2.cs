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
    // Observer interface for the 2nd observer pattern
    interface IObserver2
    {
        // As we've chosen to use Push, the Update method has 1 argument
        void Update(Portfolio portfolio);
    }
}
