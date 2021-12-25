using System;

namespace GetFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++ ) {
                string Ufamily = "Введите фамилию";
                string Uotchestvo = "Введите отчество";
                string Uname = "Введите Имя";

                string Ufamiles = lastName(Ufamily);
                string UotchestvoS = patronymic(Uotchestvo);
                string Unames = firstName(Uname);
                System.Console.WriteLine($"Ваше имя {Unames}, ваша фамилия {Ufamiles} а ваше отчество {UotchestvoS}");
            }

        }
        static string firstName(string firstName)
        {
            Console.WriteLine(firstName);
            string EnterData = Console.ReadLine();
            return EnterData;

        }
        static string lastName(string lastName)
        {
            Console.WriteLine(lastName);
            string EnterData = Console.ReadLine();
            return EnterData;

        }
        static string patronymic(string patronymic)
        {
            Console.WriteLine(patronymic);
            string EnterData = Console.ReadLine();
            return EnterData;

        }
    }
}
