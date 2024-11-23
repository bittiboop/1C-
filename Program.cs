using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate: ");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Rate {rate} of this {num} number: ");
            Console.WriteLine(num / rate);

        }
    }
}
