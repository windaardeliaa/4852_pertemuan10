using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorinter
{
    public class Canon : IPrinter
    {
        public void Show(PrinterWindows printer)
        {
            Console.WriteLine("Canon display dimension : 10*11");
        }
        public void Print(PrinterWindows printer)
        {
            Console.WriteLine("Canon printer printing...");
        }


    }
}
