using System;

namespace Multiply2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Multiplier();
            var y = x.Multiply(3, 22);
            Console.WriteLine($"Result: {y}");
        }
    }
}
