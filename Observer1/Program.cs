using System;

namespace Observer1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Batman"));
            ibm.Attach(new Investor("Superman"));

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
        }
    }
}
