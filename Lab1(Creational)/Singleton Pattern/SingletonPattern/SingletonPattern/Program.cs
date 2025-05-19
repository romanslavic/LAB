using SingletonPattern;

Console.WriteLine("Insert username:");
string? username = Console.ReadLine();
Console.WriteLine("Insert password:");
string? password = Console.ReadLine();

TwoFactorAuthentication.print();

var twoFactorAuth1 = TwoFactorAuthentication.Instance;
var twoFactorAuth2 = TwoFactorAuthentication.Instance;
if (twoFactorAuth2 == twoFactorAuth1)
{
    Console.WriteLine("The same!!!!");
}
twoFactorAuth1.GenerateTwoFactorCode();
Console.WriteLine("Insert code:");
string? inputCode = Console.ReadLine();
if (twoFactorAuth2.IsCodeValid(inputCode))
{
    Console.WriteLine("Success");
}
else
{
    Console.WriteLine("Invalid code");
}