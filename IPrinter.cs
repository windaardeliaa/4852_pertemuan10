using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorinter
{
    interface IPrinter
    {
        //method atau abstrak
        void Show(PrinterWindows printer);
        void Print(PrinterWindows printer);
    }
}
