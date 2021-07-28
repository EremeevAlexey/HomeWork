using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Поиск наибольшего общего делителя.\nВведите число A");
                string line1 = Console.ReadLine();
                int a = Convert.ToInt32(line1);

                Console.WriteLine("Введите число B");
                string line2 = Console.ReadLine();
                int b = Convert.ToInt32(line2);

                if (a >= b)
                {

                    while (b != 0)
                    {
                        //находим наибольший общий делитель
                        int c = a % b;
                        int f = a / b;
                        Console.WriteLine(a + " делится на " + b + " всего " + f + " раз с остатком от деления " + c);
                        if (c == 0)
                        {
                            Console.WriteLine("Наибольший общий делитель " + b);
                        }
                        //переопределяем значение переменных для следующего цикла
                        int d = c;
                        a = b;
                        b = d;

                    }
                }

                else
                {
                    while (a != 0)
                    {
                        //находим наибольший общий делитель
                        int c = b % a;
                        int f = b / a;
                        Console.WriteLine(b + " делится на " + a + " всего " + f + " раз с остатком от деления " + c);
                        if (c == 0)
                        {
                            Console.WriteLine("Наибольший общий делитель " + a);
                        }
                        //переопределяем значение переменных для следующего цикла
                        int d = c;
                        b = a;
                        a = d;
                    }
                }
                Console.Write("Поиск наибольшего общего делителя.\nВведите количество чисел для проверки:");


                int elementsArray = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[elementsArray];

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Введите число {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(array);

                int valueA = array[0];
                int valueB = array[array.Length];

                while (valueA != 0)
                {
                    int remains = valueB % valueA;
                    if (remains == 0)
                    {
                        Console.WriteLine("Наибольший общий делитель " + valueA);

                    }

                    else if (remains > 0)
                    {

                        valueB = valueA;
                        valueA = remains;


                    }

                    else if (args.Length > 1)
                    {
                        valueA = array[array.Length - 1];

                    }
                }
            }
        }
    }
}
