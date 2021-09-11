using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product { Name = "PlayStation", ShopName = "Sony" },
                new Product { Name = "iPhone 12Pro", ShopName = "iStore" },
                new Product { Name = "Redmi 9 Pro", ShopName = "MiStore" },
                new Product { Name = "Huawei mate 10", ShopName = "Huawei" },
                new Product { Name = "Samsung galaxy s10", ShopName = "Samsung" }
            };
            
            Array.Sort(products, Product.CompareShops);


            Console.Write("Введите название магазина:");
            string checkShopName = Console.ReadLine();
            bool startException = false;

            foreach (var nameShop in products)
            {
                if (nameShop.ShopName == checkShopName)
                {
                    Console.WriteLine($"\nВ магазине {nameShop.ShopName} продается {nameShop.Name}");
                    startException = true;
                }
                
            }

            if (!startException)
            {
                throw new ShopNotFoudException(checkShopName);
            }

            Console.ReadKey();
        }
    }
}
