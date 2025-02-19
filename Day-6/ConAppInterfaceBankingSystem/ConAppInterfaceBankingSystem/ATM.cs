using System;
namespace ConAppInterfaceBankingSystem
{
   public class ATM
    {   static void Main(string[] args)
        {   Console.WriteLine("Welcome to ATM");
            Console.WriteLine("Choose Account Type \n 1. Saving \n 2. Current");
            IAccount account;
            int acType=int.Parse(Console.ReadLine());
            switch(acType)
            {
                case 1:
                    {  account = new SavingAccount();
                        break;
                    }
                    case 2:
                    {   account = new CurrentAccount();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Choice");
                        return;
                    }
            }
            Console.WriteLine("Choose Transaction 1.Balance 2.Deposit 3.Withdraw");
            int op=int.Parse(Console.ReadLine()) ;  
            switch(op)
            {
                case 1:
                    {   Console.WriteLine("Account Balance: \t"+account.Balance);
                        break; }
                case 2:
                    {
                        Console.WriteLine("Enter Amount to Deposit");
                       Console.WriteLine("Balance after Transaction: \t"+account.Deposit(double.Parse(Console.ReadLine())));
                        break; }
                case 3:
                    {   Console.WriteLine("Enter Amount to Withdraw");
                        Console.WriteLine("Balance after Transaction: \t" + account.WithDraw(double.Parse(Console.ReadLine())));
                        break;
                    }
                 default:
                    {  Console.WriteLine("Invalid Choice");
                        break; }

            }
            Console.ReadKey();
        }
    }
}
