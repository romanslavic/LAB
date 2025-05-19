using VisitorPattern.Interfaces;

namespace VisitorPattern.Assets;

public class Ethereum : ICryptoAsset
{
    public decimal Amount { get; set; }

    public Ethereum(decimal amount)
    {
        Amount = amount;
    }

    public void Accept(ICryptoVisitor visitor)
    {
        visitor.Visit(this);
    }
}