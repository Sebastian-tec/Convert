using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degreecalc
{
    internal class MeterToFeet
    {
        public void MeterTo()
        {
            double numb;
            do
            {
                Console.Write("Meter: ");
            } while (!double.TryParse(Console.ReadLine(), out numb));

            double yard = MeterToYardConv(numb);
            double feet = MeterToFeetConv(numb);
            Console.WriteLine($"{numb} meter to Yard: {yard:N2}\n{numb} meter to Feet: {feet:N2}");

            CmToInch cmToInch = new CmToInch();
            cmToInch.CmTo();
        }

        public double MeterToYardConv(double meter)
        {
            return meter * 1.0936;
        }

        public double MeterToFeetConv(double meter)
        {
            return meter * 3.28084;
        }
    }
}
