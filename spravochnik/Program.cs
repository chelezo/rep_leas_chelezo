using System;

namespace spravochnik
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arraySpravochnik = new string [,]
            {
               { "Петров Александр","Телефон 098543245",},
               { "Иванов Петр","Телефон 0943568903" },
               { "Киркоров Андрей", "Email ololo@gmail.com" },
               { "Литвиненко Алексей", "Телефон 0847532218"},
               { "Андриенко Максим"," email lobzik@gmail.com" }

            };
            //Console.WriteLine(arraySpravochnik.Length);
            arraySpravochnik[0,0] = "Фамилия";
            arraySpravochnik[0,1] = "Телефон или Емейл";
            Console.WriteLine("Введите фамилию (Петров Иванов Киркоров)");
            string enterFamily = Console.ReadLine();
            bool Found = false;

            for (int i=0; i < arraySpravochnik.Length; i++)
                
            {
                //int Spravochnik = (i++);

                if (arraySpravochnik[i,0] == enterFamily)
                {
                    Console.WriteLine($" Житель  {arraySpravochnik[i,0]} найден ");
                  //  switch (i)
                  //  {
                  //      case 0:
                  //          Console.WriteLine("Номер телефона 096553221 Емейл ree@gmail.com");
                  //          break;
                  //      case 1:
                  //          Console.WriteLine("Номер телефона 053213228 Емейл buu@gmail.com");
                  //          break;
                  //      case 2:
                  //          Console.WriteLine("Номер телефона 053563333 Емейл ololo@gmail.com");
                  //          break;
                  //  }
                    
                        
                        Found = true;
                                      
                    
                }
                
               
            }
            if (!Found)
            {
                Console.WriteLine("Такой фамилии нет :(");
                return;
            }
        }
    }
}
