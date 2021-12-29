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
            Winter ,
            Spring ,
            Summer ,
            Autumn 
        }
        static void Main(string[] args)

        {
            //System.Console.WriteLine(Months.Winter);
            int MonthInt;
            Seasons SeasonsRead = Seasons.Winter | Seasons.Spring | Seasons.Autumn;
            MonthInt = Convert.ToInt32(System.Console.ReadLine());
            var SeasConsole = (Months)MonthInt;
            //System.Console.WriteLine(SeasConsole);

            if (MonthInt < 3 || MonthInt == 12)
                Console.WriteLine($"{Seasons.Winter}, {SeasConsole} ");
            else if (MonthInt < 6)
                Console.WriteLine($"{Seasons.Spring}, {SeasConsole} ");
            else if (MonthInt < 9)
                Console.WriteLine($"{ Seasons.Summer}, {SeasConsole} ");
            else if (MonthInt < 12)
                Console.WriteLine($"{Seasons.Autumn}, {SeasConsole} ");
            else
                Console.WriteLine("Шота вы не то тыцнули");
        }
    }
}
