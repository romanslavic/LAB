namespace SingletonPattern;

public class TwoFactorAuthentication
{
    public static readonly TwoFactorAuthentication? Instance = new TwoFactorAuthentication();
    
    private readonly Random _random = new Random();

    private string code;

    public static TwoFactorAuthentication GetInstance()
    {
        return Instance;
    }

    public void GenerateTwoFactorCode()
    {
        code = _random.Next(99).ToString();
        Console.WriteLine($"Your code is: {code}");
    }

    public bool IsCodeValid(string input)
    {
        return input.Equals(code);
    }

    public static void print()
    {
        Console.WriteLine("printed code");
    }
}