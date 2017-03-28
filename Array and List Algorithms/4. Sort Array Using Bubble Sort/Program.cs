namespace _4.Sort_Array_Using_Bubble_Sort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split(' ');
           
            bool swaped;

            do
            {
                swaped = false;
                for (int j = 0; j <= arr.Length ; j++)
                {
                    for (int i = 0; i <= arr.Length ; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            t = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = t;
                        }
                    }
                }
            } while (swaped);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

