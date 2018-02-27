using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

// Group 19
// Anni L.W.
// Emma P.J.
// Morten F.E.
namespace Observerassignment
{
    // PortfolioDisplay is an observer in the second observer pattern and therefore implements the interface IObserver2
    class PortfolioDisplay : IObserver2
    {

        private Portfolio _portfolio;

        // Method to choose, which portofolio(s) the PortfolioDisplay should observe
        public void AddPortfolio(Portfolio portfolio)
        {
            portfolio.Attach(this);
        }

        // Update method that saves the portfolio in a local variable and calls the display-method
        public void Update(Portfolio portfolio)
        {
            _portfolio = portfolio;
            
            Display();
        }

        // Method to display the stock properties contained in the received portfolio
        public void Display()
        {

            Console.WriteLine("Der er opdaterede aktier! De kommer her:");
            foreach (var i in _portfolio.Stocks)
            {
                
                Console.WriteLine(i.ToString());

                
            }
            Console.WriteLine("Værdien af dit portefølje er nu " + Convert.ToString(_portfolio.CalcTotalValue()) + " DKK \n");
        }

        
    }
}
