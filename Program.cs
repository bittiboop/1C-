namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            try
            {

                Console.WriteLine("Enter a 6-digit number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int ReversedNum = 0;

                if (num > 99999 && num < 1000000)
                {
                    while (num > 0)
                    {
                        int remainder = num % 10;
                        ReversedNum = (ReversedNum * 10) + remainder;
                        num = num / 10;
                    }
                    Console.WriteLine(ReversedNum);
                }
                else
                {
                    Console.WriteLine("Please enter a 6-digit number.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            
        }
    }
}
