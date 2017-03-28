namespace _3.Reverse_Array_In_place
{
    using System;

    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
