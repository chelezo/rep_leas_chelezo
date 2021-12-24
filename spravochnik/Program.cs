using System;

namespace spravochnik
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arraySpravochnik = new string [,]
            {
               { "Петров","Телефон 098543245",},
               { "Иванов","Телефон 0943568903" },
               { "Киркоров", "Email ololo@gmail.com" },
               { "Литвиненко", "Телефон 0847532218"},
               { "Андриенко"," email lobzik@gmail.com" }

            };
           // Console.WriteLine(arraySpravochnik[0,1]);
            //arraySpravochnik[0,0] = "Фамилия";
            //arraySpravochnik[0,1] = "Телефон или Емейл";
            Console.WriteLine("Введите фамилию (Петров Иванов Киркоров)");
            string enterFamily = Console.ReadLine();
            bool Found = false;

            for (int i = 0; i < arraySpravochnik.Length; i++)
                
            {
               
                      
                    //int Spravochnik = (i++);

                    if (arraySpravochnik[i, 0] == enterFamily)
                    {
                        Console.WriteLine($" Житель  {arraySpravochnik[i,0]} найден ");
                         switch (i)
                         {
                              case 0:
                                  Console.WriteLine(arraySpravochnik[0, 1]);
                                  break;
                              case 1:
                            Console.WriteLine(arraySpravochnik[1, 1]);
                            break;
                             case 2:
                            Console.WriteLine(arraySpravochnik[2, 1]);
                            break;
                        case 3:
                            Console.WriteLine(arraySpravochnik[3, 1]);
                            break;
                        case 4:
                            Console.WriteLine(arraySpravochnik[4, 1]);
                           break;
                    }


                        Found = true;
                    //Console.WriteLine($" Его {i} ");



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
