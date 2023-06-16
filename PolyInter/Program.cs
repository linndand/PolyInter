using PolyInter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            Console.WriteLine("Pilih Printer");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.Write("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());
            printer.Jenis = nomorPrinter;

            IPrinters show;
            IPrinters print;

            if (printer.Jenis == 1)
                show = new Epson();
            else if (printer.Jenis == 2)
                show = new Canon();
            else
                show = new LaserJet();

            if (printer.Jenis == 1)
                print = new Epson();
            else if (printer.Jenis == 2)
                print = new Canon();
            else
                print = new LaserJet();

            show.Show(printer);
            print.Print(printer);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
