using System;

namespace DateTimeLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //DateTime dt_MyDate = new DateTime(1999,10,5);
            DateTime dt_MyDate = DateTime.Now;
            

            Console.WriteLine("dt_MyDate = " + dt_MyDate.ToShortDateString());
            Console.WriteLine("dt_MyDate  + 10 days = " + dt_MyDate.AddDays(10));

            String str_FormattedDate = string.Format("My Formatted Date is {0:yyyy MMM d HH mm ss tt}", dt_MyDate);
            Console.WriteLine("str_FormattedDate = " + str_FormattedDate);

            //First Format: 30-09-2017 09:09:59
            //Second Format: Friday of month September year 2017
            //Third format: Day Friday
            //              Month September
            //              Year 2017

            dt_MyDate = DateTime.Now;
            String str_FirstFormat = string.Format("{0:MM-d-yyyy hh:mm:ss}", dt_MyDate);
            Console.WriteLine("str_FirstFormat = " + str_FirstFormat);

            String str_SecondFormat = string.Format("{0:dddd 'of month' MMMM 'year' yyyy}", dt_MyDate);
            Console.WriteLine("str_SecondFormat = " + str_SecondFormat);

            String str_ThirdFormat = string.Format("{0:'\r\nDay' dddd '\r\nMonth' MMMM '\r\nYear' yyyy}", dt_MyDate);
            Console.WriteLine("str_ThirdFormat = " + str_ThirdFormat);

        }
    }
}