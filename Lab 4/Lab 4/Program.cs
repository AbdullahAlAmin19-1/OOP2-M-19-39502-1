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
            Console.WriteLine("#####Savings Accounts#####");
            Console.WriteLine();
            Savings s1 = new Savings("Abdullah", "1234", 5000);
            Savings s2 = new Savings("Al-Amin", "4321", 4000);
            s1.Withdraw(500);
            s1.Deposit(1000);
            s1.Transfer(1000, s2);
            Console.WriteLine();
            Console.WriteLine("#####SpecialCurrent Accounts#####");
            Console.WriteLine();
            SpecialCurrent sc1 = new SpecialCurrent("Abdullah", "1234", 5000);
            SpecialCurrent sc2 = new SpecialCurrent("Al-Amin", "4321", 4000);
            sc1.Withdraw(500);
            sc1.Deposit(1000);
            sc1.Transfer(5000, sc2);
            Console.WriteLine();
            Console.WriteLine("#####Fixed Accounts#####");
            Console.WriteLine();
            Fixed f1 = new Fixed("Abdullah", "1234", 5000, 4);
            Fixed f2 = new Fixed("Al-Amin", "4321", 4000, 3);
            f1.Withdraw(500);
            f1.Deposit(1000);
            f1.Transfer(5000, f2);
            Console.WriteLine();
            Console.WriteLine("#####OverDraft Accounts#####");
            Console.WriteLine();
            OverDraft od1 = new OverDraft("Abdullah", "1234", 5000);
            OverDraft od2 = new OverDraft("Al-Amin", "4321", 4000);
            od1.Withdraw(500);
            od1.Deposit(1000);
            od1.Transfer(5000, od2);
        }
    }
}
