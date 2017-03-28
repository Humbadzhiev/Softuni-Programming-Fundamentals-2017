namespace _2.Smallest_Element_in_Array
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var smallestIntiger = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (smallestIntiger > arr[i])
                {
                    smallestIntiger = arr[i];
                }
            }
            Console.WriteLine(smallestIntiger);
        }
    }
}
