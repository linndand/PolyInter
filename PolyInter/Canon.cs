using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class Canon : IPrinters
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("Canon printer printing.....");
        }
    }
}
