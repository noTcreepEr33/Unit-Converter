using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the unit converter!");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("Select an option:");
            Console.WriteLine("1. Convert a KG to Grams");
            Console.WriteLine("2. Convert a Gram to KG");
            Console.WriteLine("3. Convert a Milli Meter to Centi Meters");
            Console.WriteLine("4. Convert a Centi Meter to Milli Meters");
            Console.WriteLine("5. Convert a  Centi Meter to Inches");
            Console.WriteLine("6. Convert a Inch to Centimeters");
            Console.WriteLine("7. Convert a Centi Meter to Meters");
            Console.WriteLine("8. Convert a Meter to Centi Meters");
            Console.WriteLine("9. Convert a Inch to Feets");
            Console.WriteLine("10. Convert a Feet to Inches");
            var operation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            if (operation == 1)
            {
                Console.WriteLine(num1 + " Kg = " + num1 * 1000 + " Gram");
            }
            else if (operation == 2)
            {
                Console.WriteLine(num1 + " Grams = " + num1 / 1000 + " KG");
            }
            else if (operation == 3)
            {
                Console.WriteLine(num1 + " Milli Meter = " + num1 / 10 + " Centi Meter");
            }
            else if (operation == 4)
            {
                Console.WriteLine(num1 + " Centi Meter = " + num1 * 10 + " Milli Meters");
            }
            else if (operation == 5)
            {
                Console.WriteLine(num1 + " Centi Meter = " + num1 / 2.5 + " Inches");
            }
            else if (operation == 6)
            {
                Console.WriteLine(num1 + " Inches = " + num1 * 2.5 + " Centi Meters");
            }
            else if (operation == 7)
            {
                Console.WriteLine(num1 + " Centi Meter = " + num1 / 100 + " Meters");
            }
            else if (operation == 8)
            {
                Console.WriteLine(num1 + " Meters = " + num1 * 100 + " Centi Meters");
            }
            else if (operation == 9)
            {
                Console.WriteLine(num1 + " Inches = " + num1 * 0.0833 + " Feets");
            }
            else if (operation == 10)
            {
                Console.WriteLine(num1 + " Feets = " + num1 / 0.0833 + " Inchs");
            }
            i = 0;
            }
        }
    }
}