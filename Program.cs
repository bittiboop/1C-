using System.Security.Cryptography;
using System.Xml.Linq;

namespace _1C_
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Choose the Fahrenheit or Celsius: ");
            Console.WriteLine("1. Fahrenheit");
            Console.WriteLine("2. Celsius");
            int choice = int.Parse(Console.ReadLine());
            double temperature;
            double result;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the temperature in Fahrenheit: ");
                    temperature = double.Parse(Console.ReadLine());
                    result = (temperature - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius: " + result);
                    break;
                case 2:
                    Console.WriteLine("Enter the temperature in Celsius: ");
                    temperature = double.Parse(Console.ReadLine());
                    result = temperature * 9 / 5 + 32;
                    Console.WriteLine("Temperature in Fahrenheit: " + result);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
