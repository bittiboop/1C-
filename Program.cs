using System.Xml.Linq;

namespace _1C_
{
    internal class Program
    {
        static void Main()
        {
            //The user enters the date from the keyboard. The application has
            //display the name of the season and day of the week.For example,
            //if entered as 12 / 22 / 2021, the app should display Winter
            //Wednesday.

            Console.WriteLine("Enter the date in the format dd/mm/yyyy: ");
            string date = Console.ReadLine();
            string[] dateArray = date.Split('/');
            int day = int.Parse(dateArray[0]);
            int month = int.Parse(dateArray[1]);
            int year = int.Parse(dateArray[2]);

            DateTime dateTime = new DateTime(year, month, day);
            string season = "";
            if (dateTime.Month == 12 || dateTime.Month == 1 || dateTime.Month == 2)
            {
                season = "Winter";
            }
            else if (dateTime.Month == 3 || dateTime.Month == 4 || dateTime.Month == 5)
            {
                season = "Spring";
            }
            else if (dateTime.Month == 6 || dateTime.Month == 7 || dateTime.Month == 8)
            {
                season = "Summer";
            }
            else if (dateTime.Month == 9 || dateTime.Month == 10 || dateTime.Month == 11)
            {
                season = "Autumn";
            }

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            Console.WriteLine($"{season} {dayOfWeek}");

        }
    }
}
