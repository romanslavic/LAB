namespace VisitorPattern.Interfaces;

public interface ICryptoAsset
{
    void Accept(ICryptoVisitor visitor);
}