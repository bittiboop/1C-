

namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            int num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("We get number: ");
            Console.WriteLine(num1 * 1000 + num2 * 100 + num3 * 10 + num4);
        }
    }
}
