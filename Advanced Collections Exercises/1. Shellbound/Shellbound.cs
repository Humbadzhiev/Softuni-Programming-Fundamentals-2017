using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            var regionName = new Dictionary<string, List<int>>();

            var input = Console.ReadLine();

            while (input != "Aggregate")
            {
                var tokens = input.Split(' ');
                var region = tokens[0];
                var shells = int.Parse(tokens[1]);

                if (!regionName.ContainsKey(region))
                {
                    regionName[region] = new List<int>();

                }

                if (!regionName[region].Contains(shells))
                {
                    regionName[region].Add(shells);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in regionName)
            {
                var regions = pair.Key;
                var vladiShells = pair.Value;
                var average = vladiShells.Average();
                var sumShells = vladiShells.Sum();
                var pcsShell = vladiShells.Count();
                var giantShell = sumShells - sumShells / pcsShell;

                Console.Write($"{regions} -> ");

                Console.Write(string.Join(", ", vladiShells));

                Console.WriteLine($" ({giantShell})");
            }
        }
    }
}
