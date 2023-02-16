using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StructPractise
{
    struct Birthday
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

       
        public Birthday(int day, int month, int year) : this()
        {
            if(year <= DateTime.Now.Year)
                Year = year;
            else
                Year = DateTime.Now.Year;

            Month = month;
            Day= day;
        }

        public void PrintBirthday() => System.Console.WriteLine(Day + "." + Month + "." + Year);
        public void DayOfBirth()
        {
            int a, y, m, R;
            a = (14 - Month) / 12;
            y = Year - a;
            m = Month + 12 * a - 2;
            R = 7000 + (Day + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12);
            switch (R % 7) {

                case 1:
                    Console.WriteLine("Monday!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("Wendesday!");
                    break;
                case 4:
                    Console.WriteLine("Thursday!");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }

        public int DaysBeforeBirthday()
        {
            return (new DateTime(DateTime.Now.Year, Month, Day) - DateTime.Now).Days;
        }
    }
    
}
