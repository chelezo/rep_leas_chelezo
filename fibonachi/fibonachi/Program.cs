using System;

namespace fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число Фибоначи");
            string FindFeb = System.Console.ReadLine();
            int FindFebN = Convert.ToInt32(FindFeb);
            int Searchfib = FibonachiNumber(FindFebN);
            Console.WriteLine($"Число Фибоначи = {Searchfib}");

            int FibonachiNumber(int a)
            {
                if (a == 0 || a == 1) return a;

                return FibonachiNumber(a - 1) + FibonachiNumber(a - 2);
            }

            
        }    
        
    }
    
}
