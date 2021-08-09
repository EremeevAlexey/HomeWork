using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание №1
            int[] myArray = new int[6];
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите число в ячейку под индексом {i}: ");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
              
            }
            Array.Sort(myArray);
            Array.Reverse(myArray);

            Console.Write("Отсортированные по убыванию значения массива: ");
            for(int l = 0; l < myArray.Length; l++)
            {
                Console.Write(myArray[l] + ", ");
                
            };
            Console.ReadKey();

            //Задание №2
            int[,] myMultidimensionalArray = 
            {
                {21, 32, 54},
                {89, 38, 12},
                {67, 85, 43}

            };

            for (int r = 0; r < 3; r++)
            {
                int max = 0;
                for (int k = 0; k < 3; k++)
                {
                    
                    if (myMultidimensionalArray[r, k] > max)
                    {
                        max = myMultidimensionalArray[r, k];
                    }
                    
                }
                Console.Write($"\nМаксимальное значение в строке {r}: {max}");
            }
            Console.ReadKey();

        }

    }
    
}
