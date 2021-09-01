using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyItem item = new MyItem();
            item.newObject = "Что то";

            MyList items = new MyList();
            items.Add(item);

            MyItem item2 = new MyItem();
            item2.newObject = "Другое что то";
            items.Add(item);

            MyItem item3 = new MyItem();
            item3.newObject = "Третье что то";
            items.Insert(1, item);

            items.RemoveAt(2);

            Console.WriteLine(items.Count);

            items.Clear();
 


        }
    }
}
