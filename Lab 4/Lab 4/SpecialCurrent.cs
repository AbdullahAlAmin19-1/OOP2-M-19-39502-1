﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class SpecialCurrent : Account
    {
        int openingBalance, minBalance;

        public SpecialCurrent(){}
        public SpecialCurrent(string accName, string accid, int balance) : base(accName, accid, balance) 
        {
            openingBalance = balance;
            minBalance = (openingBalance*10)/100;
        }

        new public void Withdraw(int amount)
        {
            if ((base.Balance - amount) >= minBalance)
                base.Withdraw(amount);
            else
                Console.WriteLine("Insaficient Balance.");Console.WriteLine();
        }

        new public void Deposit(int amount) { base.Deposit(amount); }

        new public void Transfer(int amount, Account acc)
        {
            if ((base.Balance - amount) >= minBalance)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Insaficient Balance.");Console.WriteLine();
        }
    }
}
