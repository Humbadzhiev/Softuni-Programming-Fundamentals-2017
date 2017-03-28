using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Dict_Ref_Advanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var resultDict = new Dictionary<string, int>();

            while (line != "end")
            {
                var tokens = line.Split();

                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;

                if (int.TryParse(lastElement, out number))
                {
                    resultDict[firstElement] = number;
                }
                else
                {
                    if (resultDict.ContainsKey(lastElement))
                    {
                        var refValue = resultDict[lastElement];
                        resultDict[firstElement] = refValue;
                    }
                }

                line = Console.ReadLine();
            }
            foreach (var itemPricePair in resultDict)
            {
                var item = itemPricePair.Key;
                var price = itemPricePair.Value;

                Console.WriteLine($"{item} === {price}");
            }
        }
    }
}
