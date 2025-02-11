using System.Runtime.Intrinsics.X86;

namespace module_5_2
{
    class Date
    {
        private int year;
        private int month;
        private int day;

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0) year = value;
                else throw new ArgumentException("year <= 0");
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if ((value > 0) || (value <= 12)) month = value;
                else throw new ArgumentException("month < 1 or > 12");
            }
        }

        public int Day
        {
            get { return day; }
            set
            {
                int lastday = 0;
                if (month == 2)
                {
                    lastday = ((year % 100 != 0) && (year % 4 == 0)) ? 29 : 28;
                }
                else
                {
                    if ((month <= 7) & (month % 2 == 1)) lastday = 31;
                    else if ((month > 7) & (month % 2 == 0)) lastday = 31;
                }
                if ((value > 0) && (value <= lastday)) day = value;
                else throw new ArgumentException($"day < 0 or > {lastday}");
            }        
        }

        public void Show()
        {
            Console.WriteLine($"{day}.{month}.{year}г");
        }

        public Date() : this(1) { }
        public Date(int day) : this(1, day) { }
        public Date(int month, int day) : this(2000, month, day) { }
        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(2020, 2, 20);
            Date date2 = new Date() { Day = 20, Year = 9999 };
            //date.Day = -1; // Исключение
            date1.Day = 1; // OK
            date1.Show();
            date2.Show();
        }
    }
}
