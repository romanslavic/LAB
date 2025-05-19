using ObserverPattern;

BitcoinPricePublisher bitcoinPricePublisher = new BitcoinPricePublisher();

BitcoinSubscriber subscriber1 = new BitcoinSubscriber(bitcoinPricePublisher);
BitcoinSubscriber subscriber2 = new BitcoinSubscriber(bitcoinPricePublisher);

bitcoinPricePublisher.AddSubscriber(subscriber1);
bitcoinPricePublisher.AddSubscriber(subscriber2);

bitcoinPricePublisher.SetLastPrice(84498.08);