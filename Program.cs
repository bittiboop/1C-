namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 6-digit number: ");
            string number = Console.ReadLine();

            if (number.Length != 6)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            char[] digits = number.ToCharArray();
            Console.WriteLine("Enter bit numbers to replace: ");
            if(!int.TryParse(Console.ReadLine(), out int bit1) || !int.TryParse(Console.ReadLine(), out int bit2))
            {
                Console.WriteLine("Invalid bit number");
                return;
            }
            
            Console.WriteLine("Enter new bit: ");
            if (!int.TryParse(Console.ReadLine(), out int newBit))
            {
                Console.WriteLine("Invalid new bit");
                return;
            }

            char newDigit = Console.ReadKey().KeyChar;
            digits[bit1 - 1] = newDigit;
            string newNumber = new string(digits);
            Console.WriteLine($"\nNew number: {newNumber}");
        }
    }
}
