namespace ConAppInterfaceBankingSystem
{
    public interface IAccount
    {
        double Balance { get;}
        double Deposit(double amount);
        double WithDraw(double amount);

    }
}
