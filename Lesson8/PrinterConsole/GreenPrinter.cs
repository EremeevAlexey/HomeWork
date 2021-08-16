using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWork
{
    public class GreenPrinter : Printer
    {
        public override void Print(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            base.Print(text);
            Console.ResetColor();
        }
        
    }
}
