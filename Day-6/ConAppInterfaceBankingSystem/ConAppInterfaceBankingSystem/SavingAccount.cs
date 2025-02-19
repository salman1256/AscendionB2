using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterfaceBankingSystem
{
    public class SavingAccount : IAccount
    {
        double savingBal;
        public SavingAccount()
        {
            savingBal = 25000.75;
        }
        public double Balance => savingBal;

        public double Deposit(double amount)
        {    savingBal += amount;
            Console.WriteLine("Transaction Success");
            return savingBal;
        }

        public double WithDraw(double amount)
        {
            if (savingBal >= amount)
            {
                if (savingBal - amount >= 10000)
                {
                    savingBal -= amount;
                    Console.WriteLine("Transaction Success");
                }
                else
                {   Console.WriteLine(" MAB is 10K for your account");
                    Console.WriteLine("Transaction Failed");
                }
            }
            else { Console.WriteLine("Insufficient Amount in Account"); }
            return savingBal;
        }
    }
}
