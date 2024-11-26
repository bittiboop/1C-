using System.Diagnostics.Metrics;
using System;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Text;

namespace _1C_
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter two numbers for range: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine("Even numbers in the range are: ");
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
