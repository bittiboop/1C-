using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the line: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the placeholder symbol: ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter the line direction (horizontal, vertical): ");
            string direction = Console.ReadLine();

            for (int i = 0; i < length; i++)
            {
                if (direction == "horizontal")
                {
                    Console.Write(symbol);
                }
                else if (direction == "vertical")
                {
                    Console.WriteLine(symbol);
                }
            }
        }
    }
}
