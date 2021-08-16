using System;
using PrinterWork;

namespace Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "Это тестовый текст для проверки рабоспособности програмы";

            Printer printer = new Printer();
            printer.Print(someText);

            GreenPrinter greenPrinter = new GreenPrinter();
            Room selectPrinter = new Room(greenPrinter);
            selectPrinter.MakeThisLazyPrinterWork(someText);

            BluePrinter bluePrinter = new BluePrinter();
            selectPrinter.setPrinter(bluePrinter);
            selectPrinter.MakeThisLazyPrinterWork(someText);

            Console.ReadKey();


        }
    }
}
