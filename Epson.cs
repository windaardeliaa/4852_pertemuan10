using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorinter
{
    public class Epson : IPrinter
    {
        public void Show(PrinterWindows printer)
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void Print(PrinterWindows printer) 
        {
            Console.WriteLine("Epson printer printing...");
        } 

       
    }
}
