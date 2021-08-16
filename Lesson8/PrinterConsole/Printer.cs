using System;

namespace PrinterWork
{
    public class Printer
    {
        public virtual void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
