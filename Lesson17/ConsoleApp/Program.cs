using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Classlibrary;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();

            List<Car> cars = new List<Car>();

            timer.Start();
            for (int car = 0; car <= 100000000; car++)
            {
                Random rnd = new Random();
                int randomAge = rnd.Next(1, 7);

                cars.Add(new Car { Age = randomAge } );
            }
            timer.Stop();

            Console.WriteLine($"Время создания машинок: {timer.Elapsed} мс.");
            Console.WriteLine(new string('*', 50));

            //обычным foreach пройтись по листу и изменить Age на(343 * 34 * 2 * 77)/ 567
            timer.Restart();
            foreach (var car in cars)
            {
                car.Age += (343 * 34 * 2 * 77) / 567;
                
            }
            timer.Stop();

            Console.WriteLine($"Время выполнения цикла foreach: {timer.Elapsed} мс.");
            Console.WriteLine(new string('*', 50));


            //сделать это же в for цикле
            timer.Restart();
            for (int car = 0; car < cars.Count; car++)
            {
                cars[car].Age += (343 * 34 * 2 * 77) / 567;
            }
            timer.Stop();

            Console.WriteLine($"Время выполнения цикла for: {timer.Elapsed} мс.");
            Console.WriteLine(new string('*', 50));

            //сделать это же в for Parallel.ForEach
            timer.Restart();
            Parallel.ForEach(cars, car => 
            { 
                car.Age += (343 * 34 * 2 * 77) / 567;
            });
            timer.Stop();

            Console.WriteLine($"Время выполнения Parallel.ForEach: {timer.Elapsed} мс.");

            //вычитал в интернете что Parallels сильно грузит комп. Решил посчитать как работает способ AsParallel через Linq
            timer.Restart();
            cars.AsParallel().ForAll(car =>
            {
                car.Age += (343 * 34 * 2 * 77) / 567;
                //Console.WriteLine($"У машинки {cars.IndexOf(car)} успешно заменен возраст на {car.Age} лет.");
            });
            timer.Stop();

            Console.WriteLine($"Время выполнения AsParallel: {timer.Elapsed} мс.");
            Console.WriteLine(new string('*', 50));

            //сделать это же в for Parallel.For
            timer.Restart();
            Parallel.For(0, cars.Count, car =>
            {
                cars[car].Age += (343 * 34 * 2 * 77) / 567;
            });
            timer.Stop();

            Console.WriteLine($"Время выполнения Parallel.For: {timer.Elapsed} мс.");

            //способ AsParallel через Linq
            timer.Restart();
            Enumerable.Range(0, cars.Count).AsParallel().ForAll(car =>
            {
                cars[car].Age += (343 * 34 * 2 * 77) / 567;
            });
            timer.Stop();

            Console.WriteLine($"Время выполнения AsParallel: {timer.Elapsed} мс.");


        }
    }
}
