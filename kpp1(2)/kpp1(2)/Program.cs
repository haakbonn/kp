using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Newtonsoft.Json;

namespace kpp1_2_
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, double> dictionary = new Dictionary<string, double>()
        {
            {"item1", 45.50},
            {"item2", 35},
            {"item3", 41.30},
            {"item4", 55},
            {"item5", 24}
        };

            // Виведення на екран три найбільших значень ключів
            var sortedItems = dictionary.OrderByDescending(pair => pair.Value).Take(3);
            foreach (var item in sortedItems)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            // Збереження результату у JSON файл
            string json = JsonConvert.SerializeObject(sortedItems.ToDictionary(x => x.Key, x => x.Value), Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("result.json", json);

            Console.ReadLine();
        }
    }
}