using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> aDictionary=new Dictionary<int, string>();
            aDictionary.Add(101,"CSE102");
            aDictionary.Add(102, "CSE1242");
            aDictionary.Add(103, "CSE10112");
            aDictionary.Add(104, "CSE10242");

            aDictionary[103] = "dfds";
            foreach (KeyValuePair<int, string> keyValuePair in aDictionary)
            {
                Console.WriteLine(keyValuePair.Key + "  " + keyValuePair.Value);
            }

            Console.WriteLine(aDictionary.ContainsKey(104));
            aDictionary.Remove(104);
            Console.WriteLine(aDictionary.ContainsKey(104));
            Console.WriteLine(aDictionary.Count);
            aDictionary
            Console.ReadLine();
        }
    }
}
