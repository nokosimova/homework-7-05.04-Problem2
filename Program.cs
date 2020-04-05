using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Problem 2 : Making the Converter class
           Console.WriteLine("---------------------------------");
           Console.Write("Here you can convert somoni in usd, eur or rub or vice versa");
           Console.WriteLine("Please, choose the type of converting:");
           Console.WriteLine("Convert somoni to dollar - 1");
           Console.WriteLine("Convert somoni to euro   - 2");
           Console.WriteLine("Convert somoni to ruble  - 3");
           Console.WriteLine("Convert dollar to somoni - 4");
           Console.WriteLine("Convert euro to somoni   - 5");
           Console.WriteLine("Convert ruble to somoni  - 6");
           int choice = int.Parse(Console.ReadLine());
           Console.WriteLine("Now, write down the sum: ");
           int summ = int.Parse(Console.ReadLine());
           switch(choice)
           {
               case 1:
                   Console.WriteLine($"{summ} somoni == {ConvertSomToUsd(summ)} dollar");
                   break;
               case 2:
                   Console.WriteLine($"{summ} somoni == {ConvertSomToEur(summ)} euro");
                   break;
               case 3:
                   Console.WriteLine($"{summ} somoni == {ConvertSomToRub(summ)} ruble");
                   break;
               case 4:
                   Console.WriteLine($"{summ} dollars == {ConvertUsdToSom(summ)} somoni");
                   break;
               case 5:
                   Console.WriteLine($"{summ} euro == {ConvertEurToSom(summ)} somoni");
                   break;
               case 6:
                   Console.WriteLine($"{summ} ruble == {ConvertRubToSom(summ)} somoni");
                   break;
               default:
                   Console.WriteLine("Wrong command. Please, try again");
                   break;
           }

        }
    }
}
