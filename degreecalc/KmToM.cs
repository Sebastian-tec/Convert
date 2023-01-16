using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreecalc
{
    internal class KmToM
    {
        public void KmTo()
        {
            double km;
            do
            {
                Console.Write("kilometer: ");
            } while (!double.TryParse(Console.ReadLine(), out km));

            double miles = KmToMConv(km);
            Console.WriteLine($"{km} kilemter to miles: {miles:N2}");

            string[] args = { };
            Program.Main(args);
        }

        public double KmToMConv(double km)
        {
            return km * 0.62137119;
        }
    }
}
