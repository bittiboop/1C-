namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is: " + (num1 + num2 + num3 + num4 + num5));
            Console.WriteLine("Maximum number: ");
            for(int i = 0; i < 5; i++)
            {
                if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
                {
                    Console.WriteLine(num1);
                    break;
                }
                else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
                {
                    Console.WriteLine(num2);
                    break;
                }
                else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
                {
                    Console.WriteLine(num3);
                    break;
                }
                else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
                {
                    Console.WriteLine(num4);
                    break;
                }
                else if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
                {
                    Console.WriteLine(num5);
                    break;
                }
            }
            Console.WriteLine("Minimum number: ");
            for (int i = 0; i < 5; i++)
            {
                if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
                {
                    Console.WriteLine(num1);
                    break;
                }
                else if (num2 < num1 && num2 < num3 && num2 < num4 && num2 < num5)
                {
                    Console.WriteLine(num2);
                    break;
                }
                else if (num3 < num1 && num3 < num2 && num3 < num4 && num3 < num5)
                {
                    Console.WriteLine(num3);
                    break;
                }
                else if (num4 < num1 && num4 < num2 && num4 < num3 && num4 < num5)
                {
                    Console.WriteLine(num4);
                    break;
                }
                else if (num5 < num1 && num5 < num2 && num5 < num3 && num5 < num4)
                {
                    Console.WriteLine(num5);
                    break;
                }
            }
            Console.WriteLine("Product of the numbers: " + (num1 * num2 * num3 * num4 * num5));

        }
    }
}
