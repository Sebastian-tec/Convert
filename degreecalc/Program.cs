global using System;


namespace degreecalc
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            double degree;

            do
            {
                Console.Write("Celsius: ");
            } while (!double.TryParse(Console.ReadLine(), out degree));

            double fahr = CelsToFahrConv(degree);

            Console.WriteLine($"{degree} celsius to faahrenheit: {fahr}");

            do
            {
                Console.Write("Fahrenheit: ");
            } while (!double.TryParse(Console.ReadLine(), out degree));

            double cels = FahrToCelsConv(degree);

            Console.WriteLine($"{degree} fahrenheit to celsius: {cels:N2}");
            MeterToFeet meter = new MeterToFeet();
            meter.MeterTo();
        }

        public static double CelsToFahrConv(double cels)
        {
            return cels * 1.8 + 32;
        }

        public static double FahrToCelsConv(double fahr)
        {
            return (fahr - 32) * .5556;
        }


    }
}
