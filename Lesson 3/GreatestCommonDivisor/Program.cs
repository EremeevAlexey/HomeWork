using System;
using GreatestCommonDivisor;

namespace GreatestCommonDivisor
{
    class Program
    {
        //Создаем метод для расчета наибольшего общего делителя.
        static int NewDevisor(int numberA, int numberB)
        {
            while (true)
            {
                int devisor = numberA % numberB;
                if (devisor == 0)
                {
                    return numberB;
                }
                else
                {
                    int c = devisor;
                    numberA = numberB;
                    numberB = c;
                    continue;
                }

            }
        }


        static void Main(string[] array)
        {
            //создаем запрос в консоли на количество элементов массиве.
            Console.Write("Поиск наибольшего общего делителя.\nВведите количество чисел для проверки:");

            //ситываем строку и создаем массив.
            int elementsArray = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[elementsArray];

            //заполняем массив через консоль. 
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            //преобразуем массив что-бы числа шли по убыванию.
            Array.Sort(myArray);
            Array.Reverse(myArray);


            //считаем наибольший общий делитель для первых двух чисел через созданный метод.
            int devisor1 = NewDevisor(myArray[0], myArray[1]);

            /*проверяем все элементы массива на наибольший общий делитель.
            Если не подходит то предаем новые заначения для расчета*/
            for (int j = 0; j < myArray.Length; j++)
            {

                int result = myArray[j] % devisor1;
                if (result != 0)
                {
                    int devisor2 = NewDevisor(myArray[j], devisor1);
                    devisor1 = devisor2;
                }
                else
                    continue;
            }

            //Вывод наибольшего общего делителя.
            Console.WriteLine($"Наибольший общий делитель для этих {elementsArray} чисел равна {devisor1}.");
            Console.ReadKey();
        }
    }
}
