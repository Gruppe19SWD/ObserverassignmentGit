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
    class Program
    {
        static void Main(string[] args)
        {
            // Creating stocks
            Stock vestas = new Stock("Vestas", 32,3);
            Stock mjølner = new Stock("Mjølner", 20,7);
            Stock nordea = new Stock("Nordea", 15,8);

            // Creating a portofolio to keep track of the stocks
            Portfolio portfolio = new Portfolio();
            
            // Creating a portfoliodisplay to show information
            PortfolioDisplay display = new PortfolioDisplay();
            
            // Adding the wanted stocks to the portfolio
            portfolio.AddStock(vestas);
            portfolio.AddStock(mjølner);
            portfolio.AddStock(nordea);
            
            // Adding the portfolio for which the portfoliodisplay should keep an eye on
            display.AddPortfolio(portfolio);

            // Displaying current stocks by name and value
            Console.WriteLine("Der er lige nu følgende stocks:\n");
            // Going through the list of stocks in the portfolio
            foreach (Stock stock in portfolio.Stocks)
            {
                Console.WriteLine(stock.ToString());
            }

            

            // Updating stock values by calling the UpdateValue method on each stock
            while (true)
            {
                if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    break;
                }
                foreach (Stock stock in portfolio.Stocks)
                {
                    stock.UpdateValue();
                }
                System.Threading.Thread.Sleep(2000);
                
            }
            

            /*
             * Initial coding to test
             */
            //Console.WriteLine("Indtast stock, som du ønsker at ændre værdi for:");
            //stocknavn = Console.ReadLine();
            //stocknavn = stocknavn.ToLower();
            //foreach (Stock stock in stocks)
            //{
            //    if (stock.Name.ToLower() == stocknavn)
            //    {
            //        stock.ChangeValue();
            //    }
            //}
            ////mjølner.ChangeValue();
            ////vestas.ChangeValue();

            //Console.WriteLine("Hvis du ønsker at ændre flere værdier tast 1, ønsker du at se nuværende stock og værdier tast 2");
            //int input = Convert.ToInt32(Console.ReadLine());
            //if (input == 1)
            //{
            //    Console.WriteLine("Indtast stock, som du ønsker at ændre værdi for:");
            //    stocknavn = Console.ReadLine();
            //    stocknavn = stocknavn.ToLower();
            //    foreach (Stock stock in stocks)
            //    {
            //        if (stock.Name.ToLower() == stocknavn)
            //        {
            //            stock.ChangeValue();
            //        }
            //    }
            //}
            //else if (input == 2)
            //{
            //    Console.WriteLine("Der er lige nu følgende stocks:\n\t {0}\t {1}\n\t{2}\t {3}\n", vestas.Name, vestas.Value, mjølner.Name, mjølner.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Du har indtastet en ugyldig værdi");
            //}
            
        }
    }
}
