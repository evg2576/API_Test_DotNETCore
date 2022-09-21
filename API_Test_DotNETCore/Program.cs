using API_Test_DotNETCore;
RootObject rootObject = new RootObject();
var data = await APIHandler.GetDataAsync("https://api.binance.com/api/v3/exchangeInfo?symbol=BNBBTC");
Console.WriteLine(data.symbols[0].symbol);