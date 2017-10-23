using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, long>> countryCity = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, long> countries = new Dictionary<string, long>();

        while (input != "report")
        {
            string[] data = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            string country = data[1];
            string city = data[0];
            long population = long.Parse(data[2]);

            if (!countryCity.ContainsKey(country))
            {
                countryCity.Add(country, new Dictionary<string, long>());

                countries.Add(country, 0);
            }

            countries[country] += population;

            if (!countryCity[country].ContainsKey(city))
            {
                countryCity[country].Add(city, 0);
            }

            countryCity[country][city] += population;


            input = Console.ReadLine();
        }

        var sorteredCountries = countries.OrderByDescending(x => x.Value);

        foreach (var item in sorteredCountries)
        {
            var sorteredCountryCity = countryCity[item.Key].OrderByDescending(x => x.Value);

            Console.WriteLine(item.Key + " (total population: " + item.Value + ")");

            foreach (var itemSecond in sorteredCountryCity)
            {
                Console.WriteLine("=>" + itemSecond.Key + ": " + itemSecond.Value);
            }
        }
    }
}
