using VisitorPattern.Interfaces;

namespace VisitorPattern.Assets;

public class Stablecoin : ICryptoAsset
{
    public string Symbol { get; set; }
    public decimal Amount { get; set; }

    public Stablecoin(string symbol, decimal amount)
    {
        Symbol = symbol;
        Amount = amount;
    }

    public void Accept(ICryptoVisitor visitor)
    {
        visitor.Visit(this);
    }
}