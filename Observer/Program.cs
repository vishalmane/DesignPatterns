﻿using System;

namespace Observer
{
    // The Observer design pattern defines a one-to-many dependency between objects
    // so that when one object changes state, all its dependents 
    // are notified and updated automatically. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors

            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Wait for user

            Console.ReadKey();
        }
    }
}
