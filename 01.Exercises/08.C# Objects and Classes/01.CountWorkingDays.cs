using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CountWorkingDays
{
    class Program
    {
        static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int countWorkingDays = 0;

            List<DateTime> holidays = new List<DateTime>();

            holidays.Add(new DateTime(2016, 1, 1));
            holidays.Add(new DateTime(2016, 3, 3));
            holidays.Add(new DateTime(2016, 5, 1));
            holidays.Add(new DateTime(2016, 5, 6));
            holidays.Add(new DateTime(2016, 5, 24));
            holidays.Add(new DateTime(2016, 9, 6));
            holidays.Add(new DateTime(2016, 9, 22));
            holidays.Add(new DateTime(2016, 11, 1));
            holidays.Add(new DateTime(2016, 12, 24));
            holidays.Add(new DateTime(2016, 12, 25));
            holidays.Add(new DateTime(2016, 12, 26));




            for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {

                if (!currentDate.DayOfWeek.Equals(DayOfWeek.Saturday) && !currentDate.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    bool flag = true;
                    foreach (var holiday in holidays)
                    {
                        if ((holiday.Day == currentDate.Day) && holiday.Month == currentDate.Month)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if(flag)
                    {
                        countWorkingDays++;

                    }
                }
            }

            Console.WriteLine(countWorkingDays);

        }


    }
}