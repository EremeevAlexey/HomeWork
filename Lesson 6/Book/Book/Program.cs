using System;
using ClassLibrary;

namespace ClassLibrary
{
    class HomeWork
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Программа библиотекарь.");
            
            Book[] books = new Book[]
            {
                new Book("Мюллер Д.П.C# для чайников, Прайс.C# 7 и .NET Core.", "Библиотека №1", 49),
                new Book("Бонд Д.Г.Unity и C#. Геймдев от идеи до реализации", "Библиотека №2", 1002),
                new Book("Троелсен и Джепикс.Язык программирования C# 7 и платформы .NET и .NET Core", "Библиотека №2", 1330),
                new Book("Скит.C# для профессионалов. Тонкости программирования", "Библиотека №3", 608),
                new Book("Албахари.C# 7.0. Справочник. Полное описание языка", "Библиотека №1", 1026),
            };

            while (true)
            {
                //шапка
                Console.Write("Что будем делать?\n1)Информация о книге по номеру.\n2)Поиск самой толстой книги.\n3)Поиск по названию книги.\nСделайте свой выбор (1-3):");
                Library library = new Library(books);
                string selection = Console.ReadLine();
                switch (selection)
                {

                    case "1":
                        //вывод книги по номеру
                        Console.WriteLine("\nПро какую книгу вы хотите узнать?");

                        for (int l = 0; l < books.Length; l++)
                        {
                            Book listBook = library.BookIndex(l);
                            Console.WriteLine($"{l + 1}){listBook.BookName}");
                        }

                        Console.WriteLine("Сделайте свой выбор: ");

                        Book byIndex = library.BookIndex(int.Parse(Console.ReadLine()) - 1);
                        Console.WriteLine($"Книга {byIndex.BookName} есть в {byIndex.LibraryHaveBook} и содержит {byIndex.FullPages}");
                        Console.Write("Что бы выйти в главное меню нажмите любую клавишу.");
                        Console.ReadKey();
                        break;

                    case "2":

                        //вывод самой толстой книги
                        Book fatBook = library.FatBook();
                        Console.WriteLine($"Самая большая книга {fatBook.BookName} которя содержит {fatBook.FullPages} страниц и есть в {fatBook.LibraryHaveBook}");
                        Console.Write("Что бы выйти в главное меню нажмите любую клавишу.");
                        Console.ReadKey();
                        break;

                    case "3":

                        //поиск книги по названию
                        Console.WriteLine("Введите название книги");
                        string bookName = Console.ReadLine();
                        Book book = library.BookFinder(bookName);

                        if (book == null)
                        {
                            Console.WriteLine("К сожалению у нас нет такой книги");
                        }
                        else
                        {
                            Console.WriteLine($"Книга {book.BookName} есть в {book.LibraryHaveBook} и содержит {book.FullPages}");

                        }
                        Console.Write("Что бы выйти в главное меню нажмите любую клавишу.");
                        Console.ReadKey();
                        break;

                }

            }
            
        }
    }
}
