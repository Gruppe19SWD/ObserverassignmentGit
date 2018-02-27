using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Group 19
// Anni L.W.
// Emma P.J.
// Morten F.E.
namespace Observerassignment
{
    // Stock is a concrete subject and extends the abstract Subject class
    class Stock : Subject
    {
        // A stock consist of a name, an amount and a value
        public string Name;
        public double Value;
        public int Amount;

        // For initial usage of the stock trading system: a variable to contain the value, that the user inputs
        private int _input;

        // For exercise 4 is created variables to calculate a percentage to change the value with
        private double _percentage;
        private double _number;
        private int _sign;
        // A random generator to create a random percentage value
        public Random Random = new Random();

        // Constructor: whenever creating a stock, this stock must be given a name and a value
        public Stock(string name, double value, int amount)
        {
            Name = name;
            Value = value;
            Amount = amount;
        }

        // For initial use of the system: the value could be changed manually by input to the command prompt
        public void ChangeValue()
        {
            Console.WriteLine("Indtast værdien på stocken {0}:", this.Name);
            _input = Convert.ToInt32(Console.ReadLine());
            this.Value = _input;
            // Notifying observers about the change
            Notify(this);
        }

        // A method to generate a percentage for exercise 4, could be outsourced to different class
        private void CreatePercentage()
        {
            // Number from 0-5
            _number = Random.Next(0, 6);
            // Number from 0-1
            _sign = Random.Next(0, 2);

            // If sign is 0, the percentage should be positive
            if (_sign == 0)
            {
                _percentage = _number / 100;
            }
            // Otherwise it should be negative
            else if (_sign == 1)
            {
                _percentage = -_number / 100;
            }
        }

        // Method to the regular update of values
        public void UpdateValue()
        {
            CreatePercentage();
            this.Value += this.Value * _percentage;
            // Notifies observers about changes
            Notify(this);

        }

        // Overriding ToString method to now display properties of a stock
        public override string ToString()
        {

            return "\t" + Name + "\t" + Convert.ToString(Value) + " DKK\n \t" + "Antal: " + "\t" + Convert.ToString(Amount) + "\n";

        }
    }
}
