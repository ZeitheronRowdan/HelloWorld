using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.ReadKey();
        }
    }
}
