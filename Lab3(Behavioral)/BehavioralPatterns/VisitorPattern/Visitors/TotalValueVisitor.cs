using VisitorPattern.Assets;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Visitors;

public class TotalValueVisitor : ICryptoVisitor
{
    public decimal TotalValueUsd { get; set; }
    
    public void Visit(Bitcoin bitcoin)
    {
        TotalValueUsd += bitcoin.Amount * 1000;
    }

    public void Visit(Ethereum ethereum)
    {
        TotalValueUsd += ethereum.Amount * 600;
    }

    public void Visit(Stablecoin stablecoin)
    {
        TotalValueUsd += stablecoin.Amount * 100;
    }
}