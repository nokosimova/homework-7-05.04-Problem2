using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Problem 2 : Making the Converter class
            Converter n = new Converter(0.098, 0.091, 7.48);
            int choice;
            Console.WriteLine("---------------------------------");
            Console.Write("Here you can convert somoni in usd, eur or rub or vice versa");
            Console.WriteLine("Please, choose the type of converting:");
            Console.WriteLine("Convert somoni to dollar - 1");
            Console.WriteLine("Convert somoni to euro   - 2");
            Console.WriteLine("Convert somoni to ruble  - 3");
            Console.WriteLine("Convert dollar to somoni - 4");
            Console.WriteLine("Convert euro to somoni   - 5");
            Console.WriteLine("Convert ruble to somoni  - 6");
                while (true) 
            {
                choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > 6) {
                    Console.WriteLine("Wrong command. Please, try again");
                } else {
                    break;
                }
            }
            Console.WriteLine("Now, write down the sum: ");
           double summ = double.Parse(Console.ReadLine());
           switch(choice)
           {
               case 1:
                   Console.WriteLine($"{summ} somoni == {Converter.ConvertSomToUsd(summ)} dollar");
                   break;
               case 2:
                   Console.WriteLine($"{summ} somoni == {Converter.ConvertSomToEur(summ)} euro");
                   break;
               case 3:
                   Console.WriteLine($"{summ} somoni == {Converter.ConvertSomToRub(summ)} ruble");
                   break;
               case 4:
                   Console.WriteLine($"{summ} dollars == {Converter.ConvertUsdToSom(summ)} somoni");
                   break;
               case 5:
                   Console.WriteLine($"{summ} euro == {Converter.ConvertEurToSom(summ)} somoni");
                   break;
               case 6:
                   Console.WriteLine($"{summ} ruble == {Converter.ConvertRubToSom(summ)} somoni");
                   break;
               default:
                   break;
           }

        }

            class Converter 
        {
            public static double usd{ get; set;}
            public static double eur {get; set;}
            public static double rub {get; set;}
            public Converter(double us, double eu, double rb)
            {
                usd = us;
                eur = eu;
                rub  = rb;
            }
            public static double ConvertSomToUsd(double som) 
            {
                double us = Math.Round(som*usd,4);
                return us;
            }
            public static double ConvertSomToEur(double som)
            {
                double eu = Math.Round(som*eur,4);
                return eu;
            }
            public static double ConvertSomToRub(double som)
            {            
                double rb = Math.Round(som*rub,4);
                return rb;
            }
            public static double ConvertUsdToSom(double us)
            {
                if (usd != 0)
                {
                    double som = Math.Round(us/usd,4);
                    return som; 
                } else {
                    Console.WriteLine("Error1");
                    return 0;
                }
            }
            public static double ConvertEurToSom(double eu)
            {
                if (eur != 0)
                {
                    double som = Math.Round(eu/eur,4);
                    return som;
                } else {
                    Console.WriteLine("Error2");
                    return 0;
                }
            }
            public static double ConvertRubToSom(double rb)
            {
                if (rub != 0)
                {
                    double som = Math.Round(rb/rub,4);
                    return som;
                } else {
                    Console.WriteLine("Error3");
                    return 0;
                }
            }
        }
    /* При создании класса Converter я столкнулась с трудностью в записи статичных методов
    в главной программе Main, также много времени заняло отлаживание кода.
    После неудачных попыток написать класс в отдельном файле отдельно от Program.cs, я оставила класс в общем коде.*/
      
    }
}
