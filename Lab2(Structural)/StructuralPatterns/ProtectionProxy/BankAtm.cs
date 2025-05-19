namespace ProtectionProxy;

public class BankAtm : IBankAtm
{
    private double _balance = 1000;
    
    public void WithdrawMoney(double amount)
    {
        if (amount <= _balance)
        {
            _balance -= amount;
            Console.WriteLine($"Successfully withdrew {amount}. Remaining balance is {_balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }
}