using System;
using System.Linq;
using ClassLibrary;
using Cone;

namespace Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Что будем делать?\n1) Инвертировать массив" +
                    "\n2) Вставлять новый элемент в массив\n3) Высчитывать площадь конуса" +
                    "\n4)Высчитывать площадь основания конуса.\nСделайте свой выбор (1-4): ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        //массив который нужно ивертировать.
                        //создаем запрос на ввод чисел.
                        Console.Write("Введите через пробел числа которые будем инвертировать: ");
                        //считываем.
                        string[] inpArr = Console.ReadLine().Split(' ');

                        //Сознаем объект написанного нами класса.
                        ArrayWorker objA = new ArrayWorker();

                        //пердаем в него нашу сторку что бы он нам вернул числовой массив.
                        int[] inpArrRebild = objA.ArrayInput(inpArr);

                        //Отправляем массив на инверсию через написанный нами метод.
                        objA.sourse = inpArrRebild;
                        objA.ArrayRebild();

                        //вывод ивертированного массива.
                        Console.Write("Инвертированный массив: ");
                        foreach (int l in objA.sourse)
                        {
                            Console.Write(l + " ");
                        }
                        Console.WriteLine("\nНажмите любую клавишу что-бы продолжить.");
                        Console.ReadKey();

                        break;

                    case "2":
                        //добавление элемента в массив.
                        //Сознаем объект написанного нами класса.
                        ArrayWorker objB = new ArrayWorker();

                        //создаем запрос на ввод чисел стартового массива.
                        Console.Write("Введите через пробел числа в стартовом массиве: ");

                        //считываем.
                        string[] inpArr1 = Console.ReadLine().Split(' ');

                        //пердаем в него нашу сторку что бы он нам вернул числовой массив.
                        objB.sourse = objB.ArrayInput(inpArr1);

                        while (true)
                        {
                            //создаем запрос на ввод индекса и числа.
                            Console.Write("Введите индекс по какому вы хотите вставить значение? ");
                            objB.index = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите значение которое вы хотите вставить ");
                            objB.newValue = Convert.ToInt32(Console.ReadLine());
                            objB.ArrayInsert(objB.index, objB.newValue);

                            //вывод массива со вставленным элементом.
                            Console.Write($"Результат со вставленным элементом {objB.index}: ");
                            foreach (int l in objB.sourse)
                            {
                                Console.Write(l + " ");
                            }

                            //создаем запрос на надобность ввода еще одного значения.
                            Console.Write("\nВведите Y если хотите вставить еще одно значение или любую клавишу чтобы выйти: ");
                            string sellect = Console.ReadLine();
                            switch (sellect)
                            {
                                case "Y":
                                    continue;
                               
                            }
                            break;

                        }
                        break;
                            

                        case "3":
                        //площадь конуса.
                        //Сознаем объект написанного нами класса.
                        ConeSquare objCone = new ConeSquare();

                        //создаем запрос на ввод высоты и радиуса.
                        Console.Write("Введите высоту конуса h: ");
                        objCone.h = int.Parse(Console.ReadLine());
                        Console.Write("Введите радиус конуса r: ");
                        objCone.r = int.Parse(Console.ReadLine());

                        //пердаем значения в занее созданный метод.
                        double fullConeSquare = objCone.FullConeSquare(objCone.h, objCone.r);

                        //вывод полученного значения
                        Console.WriteLine("Полная площадь конуса равна " + fullConeSquare);

                        Console.Write("Нажмите любую клавишу что-бы продолжить.");
                        Console.ReadKey();
                        break;
                        

                    case "4":
                        //площадь основания конуса.
                        //Сознаем объект написанного нами класса.
                        ConeSquare objCone1 = new ConeSquare();

                        //создаем запрос на ввод радиуса.
                        Console.Write("Введите радиус основания конуса r: ");
                        objCone1.r = int.Parse(Console.ReadLine());

                        //пердаем значения в занее созданный метод.
                        double fullConeBaseSquare = objCone1.BaseOfCone(objCone1.r);
                        Console.WriteLine("Площадь основания конуса равна " + fullConeBaseSquare);

                        Console.Write("Нажмите любую клавишу что-бы продолжить.");
                        Console.ReadKey();
                        break;

                }
            }


        }
            
    
    }
}
