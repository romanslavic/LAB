using ProtectionProxy;

Console.WriteLine("Please enter the passcode: ");
string passcode = Console.ReadLine() ?? string.Empty;

IBankAtm bankAtm = new BankAtmProxy(passcode);

Console.WriteLine("Please enter the amount to withdraw: ");
int amountToWithdraw = int.Parse(Console.ReadLine() ?? "0");

bankAtm.WithdrawMoney(amountToWithdraw);