using System;
using System.Reflection;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите Фамилию: ");
                string firstName = Console.ReadLine();

                Console.Write("Введите Имя: ");
                string lastName = Console.ReadLine();

                Console.Write("Введите возраст: ");
                string аge = Console.ReadLine();

                Human human = new Human { Age = аge, FirstName = firstName, LastName = lastName };
                СheckByAttribute сheckByAttribute = new СheckByAttribute();
                сheckByAttribute.Сheck(human);
            }

            
        }
    }
}
