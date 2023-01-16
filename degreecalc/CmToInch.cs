using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreecalc
{
    internal class CmToInch
    {
        public void CmTo()
        {
            double cm;
            do
            {
                Console.Write("Centimeter: ");
            } while (!double.TryParse(Console.ReadLine(), out cm));

            double inch = CmToInchConv(cm);
            Console.WriteLine($"{cm} centimeter to inch: {inch:N2}");

            KmToM km = new KmToM();
            km.KmTo();

        }

        public double CmToInchConv(double cm)
        {
            return cm / 2.54;
        }
    }
}
