using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// Group 19
// Anni L.W.
// Emma P.J.
// Morten F.E.
namespace Observerassignment
{
    // Portfolio is both Subject and observer, hence extending and implementing
    class Portfolio : Subject2, IObserver
    {
        // A list of stocks to keep track of 'em
        internal List<Stock> Stocks = new List<Stock>();

        //Variable for total value in portfolio
        private double _totalvalue;


        // Update method of portfolio as an observer
        public void Update(Stock stockvalue)
        {
            // Finding what stock to change the value for
            foreach (Stock stock in Stocks)
            {
                if (stock.Name == stockvalue.Name)
                {
                    stock.Value = stockvalue.Value;
                    
                }
            }
            
            // When portfolio is updated, the portfoliodisplay should receive the updated portfolio - through the second obs. pattern
            Notify(this);
        }

        // Method to choose, which stock(s) the Portfolio should observe
        public void AddStock(Stock stock)
        {
            stock.Attach(this);

            //Add the stock to the list
            Stocks.Add(stock);
            
            
        }

        // Method to calculate total value of stocks owned
        public double CalcTotalValue()
        {
            _totalvalue = 0;
            foreach (Stock stock in Stocks)
            {
                _totalvalue += stock.Value * stock.Amount;
            }

            return _totalvalue;
        }
    }
}
