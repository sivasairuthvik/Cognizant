StockMarket stockMarket = new StockMarket();

IObserver mobile = new MobileApp();
IObserver web = new WebApp();

stockMarket.RegisterObserver(mobile);
stockMarket.RegisterObserver(web);

stockMarket.SetStock("TCS", 3850.50);

Console.WriteLine();

stockMarket.SetStock("Infosys", 1625.75);