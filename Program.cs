namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the upper limit of the range:");
            int upperBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the lower limit to the range:");
            int lowerBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci numbers in this range: ");
            List<int> fibonacciNumbers = GetFibonacciNumbersInRange(lowerBound, upperBound);
            foreach (int number in fibonacciNumbers) 
            {
                Console.WriteLine(number);
            }

            static List<int> GetFibonacciNumbersInRange(int lowerBound, int upperBound)
            {
                List<int> fibonacciNumbers = new List<int>();
                int a = 0, b = 1;
                while (a <= upperBound)
                {
                    if (a >= upperBound)
                    {
                        fibonacciNumbers.Add(a);
                    }
                    int temp = a;
                    a = temp;
                    b = temp + b;
                }
                return fibonacciNumbers;
            }
        }
    }
}
