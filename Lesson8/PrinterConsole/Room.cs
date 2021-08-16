using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWork
{
    public class Room
    {
        Printer printer = new Printer();
        public Room (Printer printer)
        {
             this.printer = printer;
        }

        public void MakeThisLazyPrinterWork(string text)
        {
            printer.Print(text);

        }

        public void newPrinter(Printer printer)
        {
            this.printer = printer;
        }

        
        



    }
}
