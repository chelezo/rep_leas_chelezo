using System;

namespace EnterSeas_Leasson4
{
    class Program
    {
        [Flags]
        enum Months
         {
             January = 1,
             February = 2,
             March = 3,
             April = 4,
             May = 5,
             June = 6,
             July = 7,
             August = 8,
             September = 9,
             October = 10,
             November = 11,
             December = 12,
         }


        [Flags]
        enum Seasons 
        {
            Winter = Months.December | Months.January | Months.February,
            Spring = Months.March | Months.April | Months.May,
            Summer = Months.June | Months.July | Months.August,
            Autumn = Months.September | Months.October | Months.November
        }
        static void Main(string[] args)
            
        {
            //System.Console.WriteLine(Months.Winter);
            int MonthInt;
            //Seasons SeasonsRead = Seasons.Winter | Seasons.Spring | Seasons.Autumn;
          // System.Console.ReadLine();
            MonthInt = Convert.ToInt32(System.Console.ReadLine());
            if () 
            { }
           // if (MonthInt == 12)
           //         {
           //     System.Console.WriteLine($"Месяц {(Months)MonthInt} время года {Seasons.Winter}");
           // }
            // string MonthInt = System.Console.ReadLine();
            // System.Console.WriteLine((Seasons)MonthInt);




        }
    }
}
