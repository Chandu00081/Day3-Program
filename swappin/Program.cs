using System;

namespace swappin
{
    internal class Swap
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("enter 1st number:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int z = int.Parse(Console.ReadLine());
            x = y;
            y = z;
            y = x;
            Console.WriteLine("After swapping:");

        }
    }
}
