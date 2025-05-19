using VisitorPattern.Assets;

namespace VisitorPattern.Interfaces;

public interface ICryptoVisitor
{
    void Visit(Bitcoin bitcoin);
    void Visit(Ethereum ethereum);
    void Visit(Stablecoin stablecoin);
}