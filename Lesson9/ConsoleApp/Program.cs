using System;
using MyCollectionBild;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun newGun = new Gun();
            MyCollection<Gun> guns = new MyCollection<Gun>();

            newGun.Name = "Макаров";
            guns.AddUnit(newGun);

            newGun.Name = "Colt M1911";
            guns.AddUnit(newGun);

            newGun.Name = "Walther P38";
            guns.AddUnit(newGun);

            newGun.Name = "Mauser C-96";
            guns.AddUnit(newGun);

            Console.WriteLine($"Всего пистолетов в коллекции: {guns.CountUnit}");
            Console.WriteLine($"В ячейке №2 находится {guns[1]}");

            Plane newPlane = new Plane();
            MyCollection<Plane> planes = new MyCollection<Plane>();

            newPlane.Name = "Миг-29";
            planes.AddUnit(newPlane);

            newPlane.Name = "Су-27УБ";
            planes.AddUnit(newPlane);

            newPlane.Name = "Messerschmitt Bf-109";
            planes.AddUnit(newPlane);

            Console.WriteLine($"Всего самолетиков в коллекции: {planes.CountUnit}");
            Console.WriteLine($"В ячейке №3 находится {planes[2]}");

            Console.ReadKey();

        }

    }
}
