using VisitorPattern.Assets;
using VisitorPattern.Interfaces;
using VisitorPattern.Visitors;

var wallet = new List<ICryptoAsset>
{
    new Bitcoin(0.5m),
    new Ethereum(2),
    new Stablecoin("USDT", 1000m)
};

var valueVisitor = new TotalValueVisitor();

foreach (var asset in wallet)
{
    asset.Accept(valueVisitor);
}

Console.WriteLine($"Total wallet value: ${valueVisitor.TotalValueUsd:N2}");