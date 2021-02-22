using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings a1 = new Savings("Abdullah", "1234", 5000);
            Savings a2 = new Savings("Al-Amin", "4321", 4000);
            a1.Withdraw(500);
            a1.Deposit(1000);
            a1.Transfer(1000, a2);

        }
    }
}
