using System.Globalization;

namespace ConsoleApp6;

public class Stock
{
    private readonly Dictionary<string, int> _stockPrices; // readonly means that u can't change the reference after the Constructor

   public Stock() //by default  is private so u have to explicitly write public
    {
        _stockPrices = new() {
            { "MSFT", 420 },
            { "AAPL", 180 }
        };
    }

    public void AddKV(string k , int v)
    {
        _stockPrices.Add(k,v);
        Console.WriteLine("The stock price has been added successfully !");
    }

    public bool CanIEditKEY(string k )
    {
        return _stockPrices.ContainsKey(k);
    }

    public void ListItems()
    {
        foreach (var stockPrice in _stockPrices)
        {
            Console.WriteLine($"{stockPrice.Key} - {stockPrice.Value}");
        }
    }

    public void CancelAnItem(string k )
    {
        int val = _stockPrices[k];
        _stockPrices.Remove(k);
        Console.WriteLine($"this pair ({k}-{val}) has been cancelled");
    }

    public void EditK(string k , string newKey)
    {
        if (!CanIEditKEY(k))
        {
            Console.WriteLine("this key is not existed !"); return;
        }

        int val = _stockPrices[k];
        _stockPrices.Remove(k);
        
        _stockPrices.Add(newKey , val);
        Console.WriteLine($"the key has been edited successfully from {k} to {newKey} ");
    }

    public void Search(string key)
    {
        if (!_stockPrices.ContainsKey(key))
        {
            Console.WriteLine("not fount this key");
        }

        int val = _stockPrices[key];
        Console.WriteLine($"{key} - {val} found");
    }

    public KeyValuePair<string, int> BiggestVal()
    {
        int max = _stockPrices.First().Value;
        string key = "";
        foreach (var keyValuePair in _stockPrices)
        {
            if (keyValuePair.Value > max)
            {
                max = keyValuePair.Value;
                key = keyValuePair.Key;
            }
        }

        return new KeyValuePair<string, int>(key,max);
    }

    public int GetQuantity(string name)
    {
        if (_stockPrices.TryGetValue(name, out int price))  // faster in term of look up 
        {
            return price;
        }
        else
        {
            return -1;
        }
    }
}
