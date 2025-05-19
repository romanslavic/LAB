namespace ProtectionProxy;

public class BankAtmProxy : IBankAtm
{
    private BankAtm _bankAtm = new();
    private readonly string _passcode;

    public BankAtmProxy(string passcode)
    {
        _passcode = passcode;
    }

    public void WithdrawMoney(double amount)
    {
        if (_passcode.Equals("2310"))
        {
            _bankAtm.WithdrawMoney(amount);
        }
        else
        {
            Console.WriteLine($"Access denied. {_passcode} is not valid.");
        }
    }
}