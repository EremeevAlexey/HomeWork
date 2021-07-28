using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 14;
            int y = 1;
            int z = 5;

            x += y - x++ * z; //-55
            Console.WriteLine(x);

            z = --x - y * 5; //-61
            Console.WriteLine(z);

            y /= x + 5 % z; //0
            Console.WriteLine(y);

            z = x++ + y * 5; //-56
            Console.WriteLine(z);

            x = y - x++ * z; // -3080
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
