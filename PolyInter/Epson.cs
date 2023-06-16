using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class Epson : IPrinters
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("Epson printer printing.....");
        }
    }
}
