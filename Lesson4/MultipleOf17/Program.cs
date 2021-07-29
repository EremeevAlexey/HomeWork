using System;

namespace MultipleOf17
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = 200;

            while (var != 500)
            {
                if (var % 17 == 0)
                {
                    Console.Write(var + ", ");
                    var++;

                }

                else
                    var++;

            }
            Console.ReadKey();
        }
    }
}
