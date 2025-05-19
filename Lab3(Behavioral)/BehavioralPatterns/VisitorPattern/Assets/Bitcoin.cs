using VisitorPattern.Interfaces;

namespace VisitorPattern.Assets;

public class Bitcoin : ICryptoAsset
{
    public decimal Amount { get; set; }

    public Bitcoin(decimal amount)
    {
        Amount = amount;
    }
    
    public void Accept(ICryptoVisitor visitor)
    {
        visitor.Visit(this);
    }
}