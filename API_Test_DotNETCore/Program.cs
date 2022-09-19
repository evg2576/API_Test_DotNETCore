using API_Test_DotNETCore;
RootObject rootObject = new RootObject();
rootObject = APIHandler.GetData<RootObject>("https://api.binance.com/api/v3/exchangeInfo?symbol=BNBBTC");
Console.WriteLine();