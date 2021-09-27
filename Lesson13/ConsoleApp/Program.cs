using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //создать Product[5].
            Product[] products =
            {
                new Product { Produkt = "PlayStation", ShopName = "Sony" },
                new Product { Produkt = "iPhone 12Pro", ShopName = "iStore" },
                new Product { Produkt = "Redmi 9 Pro", ShopName = "MiStore" },
                new Product { Produkt = "Huawei mate 10", ShopName = "Huawei" },
                new Product { Produkt = "Samsung galaxy s10", ShopName = "Samsung" }
            };

            //Отсортировать в алфавитном порядке по названиям магазинов.
            Compare compare = new Compare();
            Array.Sort(products, compare.CompareShops);
           
            Console.WriteLine("Какой магазин вас интересует?");
            foreach (var prod in products)
                Console.WriteLine(prod.ShopName);

            //Вводим с клавиатуры название магазина.
            Console.Write("\nВведите название магазина: ");
            string checkShopName = Console.ReadLine();

            //Получаем все товары данного магазина -> если такого магазина нет, выдаем наше кастомное исключение.
            FoundProdukts foundProdukt = new FoundProdukts();
            foundProdukt.FoundProdukt(products, checkShopName);
            Console.WriteLine(foundProdukt.Result);           
 
            Console.ReadKey();
        }
    }
}
