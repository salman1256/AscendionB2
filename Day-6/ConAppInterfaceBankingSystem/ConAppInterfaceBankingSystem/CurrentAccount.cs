using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppInterfaceBankingSystem
{
    public class CurrentAccount : IAccount
    {  double currentBal;
        public CurrentAccount()
        {
            currentBal = 56000.50;
        }
        public double Balance => currentBal;

        public double Deposit(double amount)
        {
           currentBal += amount;
            return currentBal;  
        }

        public double WithDraw(double amount)
        {
            if(currentBal >=amount ) 
            {
                currentBal-=amount;
                Console.WriteLine("Transaction Success");
               
            }
            else
            {
                Console.WriteLine("You do not have sufficient amount in your current account");
                Console.WriteLine("Transaction Failed");
            }
            return currentBal;
        }
    }
}
