using System;

namespace Gaps
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число для проверки промежутка: ");
                string input = Console.ReadLine();
                int convertInput = Convert.ToInt32(input);

                if (convertInput <= 30)
                {
                    Console.WriteLine($"Число {convertInput} попадает в первый промежуток");
                }

                else if (convertInput > 30 && convertInput <= 60)
                {
                    Console.WriteLine($"Число {convertInput} попадает в второй промежуток");
                }

                else if (convertInput > 60 && convertInput <= 100)
                {
                    Console.WriteLine($"Число {convertInput} попадает в третий промежуток");
                }

                else
                    Console.WriteLine($"Я не знаю такого числа как {convertInput}");

            }
            
        }
    }
}
