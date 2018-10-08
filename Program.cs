using System;
using System.Collections.Generic;

namespace Hashset
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
                stocks.Add("GM", "General Motors");
                stocks.Add("GE", "General Electric");
                stocks.Add("CAT", "Caterpillar");
                stocks.Add("COST", "Costco");
                stocks.Add("NWL", "Newell Brands");
                stocks.Add("DISH", "Dish Network");


            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add (new Dictionary<string, double>(){ {"GE", 230.21} });
            purchases.Add (new Dictionary<string, double>(){ {"GE", 580.98} });
            purchases.Add (new Dictionary<string, double>(){ {"GE", 406.34} });
            purchases.Add(new Dictionary<string, double>(){ {"COST", 306.34} });
            purchases.Add(new Dictionary<string, double>(){ {"NWL", -250.34} });
            purchases.Add(new Dictionary<string, double>(){ {"DISH", -100.34} });


            /*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the total valuation of each stock


    From the three purchases above, one of the entries
    in this new dictionary will be...
        {"General Electric", 1217.53}

    Replace the questions marks below with the correct types.
*/
Dictionary<string, double> stockReport = new Dictionary<string, double>();
    stockReport.Add("General Electric", 1217.53 );
    stockReport.Add("Costco", 306.34);
    stockReport.Add("Newell Brand", -250.34);
    stockReport.Add("Dish Network", -100.34);
/*
   Iterate over the purchases and record the valuation
   for each stock.
*/
foreach (Dictionary<string, double> purchase in purchases) {
{
    foreach (KeyValuePair<string, double> transaction in purchase)
    {
        string fullCompanyName = stocks[transaction.Key]; 
    
        // Does the full company name key already exist in the `stockReport`?
if (stockReport.ContainsKey(fullCompanyName))
                    {
        // If it does, update the total valuation
        /*
            If not, add the new key and set its value.
            You have the value of "GE", so how can you look
            the value of "GE" in the `stocks` dictionary
            to get the value of "General Electric"?
        */
        stockReport[fullCompanyName] = stockReport[fullCompanyName] + transaction.Value;
                    } else {
                        // stockReport.Add(fullCompanyName, transaction.Value);
                        stockReport[fullCompanyName] = transaction.Value;
                    }
    }
}

        foreach (KeyValuePair<string, double> valuation in stockReport)
            {
                Console.WriteLine($"{valuation.Key} has a valuation of {valuation.Value.ToString("C")}");
            }

            
    }
}
    }
}

