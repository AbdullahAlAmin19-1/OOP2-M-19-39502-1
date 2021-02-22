using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Savings : Account
    {
        int minBalance = 430;
        public Savings(){}
        public Savings(string accName, string accid, int balance):base (accName, accid, balance)
        {
            //this.AccName = accName;
            //this.Accid = accid;
            //this.Balance = balance;
        }

        new public void Withdraw(int amount)
        {
            if (amount > minBalance)
                base.Withdraw(amount);
            else
                Console.WriteLine("Insaficient Balance.");
        }

        new public void Deposit(int amount){ base.Deposit(amount); }

        new public void Transfer (int amount, Account acc)
        {
            if (amount > minBalance)
                base.Transfer (amount,acc);
            else
                Console.WriteLine("Insaficient Balance.");
        }
    }
}
