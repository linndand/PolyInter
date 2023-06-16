using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInter
{
    public class LaserJet : IPrinters
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("LaserJet display dimension : 12*12");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("LaserJet printer printing.....");
        }
    }
}
