using System;
using System.Collections.Generic;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> countries = new List<string>();
			
			countries.Add("Holland");
			countries.Add("United States");
			countries.Add("Canada");
			countries.Add("Germany");
			countries.Add("South Africa");
			
			
			Console.WriteLine("1"+ countries.Contains("Germany"));
			Console.WriteLine("2"+ countries.Contains("Germany"));
			Console.WriteLine("3"+ countries[4]);
			Console.WriteLine("4"+ countries[1]);
			countries.Remove("Germany");
			Console.WriteLine("6"+ countries.Contains("Germany"));
			countries.Insert(4, "Mexico");
			countries.Sort();
			foreach(string country in countries){
				Console.WriteLine(countries.Contains(country));
			}
			Console.WriteLine("In list now:");
			foreach(string countryPrint in countries){
				Console.WriteLine(countryPrint);
			}
			
        }
    }
}
