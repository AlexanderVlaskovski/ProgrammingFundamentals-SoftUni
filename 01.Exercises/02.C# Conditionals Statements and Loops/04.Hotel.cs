using System;
 
namespace p04Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double Studio = 0.0;
            double Terrace = 0.0;
            double Suite = 0.0;
 
            switch (month)
            {
                case "May":
                    Terrace = 65 * nightsCount;
                    Suite = 75 * nightsCount;
                    if (nightsCount > 7)
                    {
                        Studio = 50 * 0.95 * nightsCount;
                    }
                    else
                    {
                        Studio = 50 * nightsCount;
                    }
 
                    break;
                case "October":
                    Terrace = 65 * nightsCount;
                    Suite = 75 * nightsCount;
                    if (nightsCount > 7)
                    {
                        Studio = (50 * 0.95 * nightsCount) - (50 * 0.95);
                    }
                    else Studio = 50 * nightsCount;
                    break;
                case "June":
                    Studio = 60 * nightsCount;
                    Suite = 82 * nightsCount;
                    if (nightsCount > 14)
                    {
                        Terrace = 72 * 0.9 * nightsCount;
                    }
                    else Terrace = 72 * nightsCount;
                    break;
                case "September":
                  Studio = 60 * nightsCount;
                    Terrace = 72 * nightsCount;
                    Suite = 82 * nightsCount;
                    if (nightsCount > 7)
                    {
                        Studio = 60 * nightsCount - 60;
                    }
                    if (nightsCount > 14)
                    {
                        Terrace = 72 * 0.9 * nightsCount;
                    }
                    break;
                case "July":
                case "August":
                case "December":
                   Studio = 68 * nightsCount;
                    Terrace = 77 * nightsCount;
                    if (nightsCount > 14)
                    {
                        Suite = 0.85 * 89 * nightsCount;
                    }
                    else
                    {
                        Suite = 89 * nightsCount;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Studio: {Studio:f2} lv.");
            Console.WriteLine($"Double: {Terrace:f2} lv.");
            Console.WriteLine($"Suite: {Suite:f2} lv.");
        }
    }
}