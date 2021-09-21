using System;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан символ "<любой, сами решите>" и строка с текстом.
            //Найти слово, которое заканчивается на данный символ.
            //Если слова нет, то долно вернуться null.
            //Если больше одного->исключение.

            var testString = "Hello World";
            var words = testString.Split(new char[] { ' ' }).Where( x => x.Last() == 'o' ).SingleOrDefault();
            if (words == null)
            {
                Console.Write("Нет слова заканчивающегося на 'о'");
            }
            else
                foreach (var str in words)
                {
                    Console.Write(str);
                }
            Console.WriteLine("\n" + new string('*', 50));


            //b. Дано [5,8,0,-1,6,4,-1,-3]. Найти количество ее положительных элементов, а также их среднее значение.
            
            List<int> testList = new() { 5, 8, 0, -1, 6, 4, -1, -3 };
            decimal count = testList.Where(x => x > 0).Count();
            decimal averageValue = testList.Where( x => x > 0 ).Sum( y => y / count);
            Console.WriteLine(averageValue);
            Console.WriteLine(new string('*', 50));


            //в. дана строка "Женя скоро будет свободен, а у вас все только начинается" при помощи Linq убрать из строки все 'о'.Вывести на консоль результат.

            string happyMan = "Женя скоро будет свободен, а у вас все только начинается";
            var delLetter = happyMan.Split(new char[] { 'о' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var str in delLetter)
            {
                Console.Write(str);
            }
            Console.WriteLine("\n" + new string('*', 50));

            //г. придумать задачу, в которой придется использовать join, where, take, skip и select. Написать ваше реализацию.

            List<WhereBildCar> whereBildCars = new List<WhereBildCar>()
            {
                new WhereBildCar { Name = "Volkswagen", Country ="Германия" },
                new WhereBildCar { Name = "Seat", Country ="Испания" },
                new WhereBildCar { Name = "Toyota", Country ="Япония" },
                new WhereBildCar { Name = "Ford", Country ="США" }
            };

            List<Car> cars = new List<Car>()
            {
                new Car {Name="Volkswagen", Model="Tuareg"},
                new Car {Name="Volkswagen", Model="Tiguan"},
                new Car {Name="Volkswagen", Model="Amarok"},
                new Car {Name="Seat", Model="Leon"},
                new Car {Name="Toyota", Model="Camry"},
                new Car {Name="Toyota", Model="Land Cruser"},
                new Car {Name="Toyota", Model="Land Cruser Prado"},
                new Car {Name = "Ford", Model="Mustang"}
            };

            var result = from car in cars.Skip(5).Take(1)                         
                         join carInCounry in whereBildCars on car.Name equals carInCounry.Name
                         where car.Name == "Toyota"
                         select new { Name = car.Name, Model = car.Model, Country = carInCounry.Country };
                         
            foreach (var item in result)
                Console.WriteLine($"{item.Name} - {item.Model} ({item.Country})");


        }


    }
}
