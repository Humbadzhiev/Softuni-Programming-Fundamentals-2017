using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Array_Contains_Element
{

    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var element = int.Parse(Console.ReadLine());

            var isFound = false;

            for (int i = 0; i < arr.Length; i++)

            {
                if (arr[i] == element)
                {
                    isFound = true;

                    Console.WriteLine("yes");
                    break;

                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}

