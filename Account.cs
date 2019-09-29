using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherBank
{
    public class Account
    {
        public static int AccNumber;
        public string Name { get; private set; }
        public int Number { get; private set; }

        public double Cash { get; private set; }

        public Account(string name, int number, double cash)
        {
            Name = name;
            Number = number;
            Cash = cash;
            
        }

        public Account(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public Account(int number)
        {
            Number = number;
        }

        public Account()
        {
        }

        public double Deposit(double deposit_value)
        {
            return Cash += deposit_value;
        }

        public double TakeOut(double deposit_value)
        {
            return Cash -= deposit_value;
        }

       
    }
}
