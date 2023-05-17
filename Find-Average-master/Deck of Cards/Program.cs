using System;
 
namespace Deck
{
    class Program
    {
        static void Main(string[] args)
        {
          string sign = Console.ReadLine();
          int number = 0;;
          
            switch(sign) {
              case "J": number = 11; break;
              case "Q": number = 12; break;
              case "K": number = 13; break;
              case "A": number = 14; break;
              default: number = int.Parse(sign); break;
            }
          for (int i =2; i <=number; i++)
           {
               string str = "";
              switch(i) {
                  case 11: str = "J"; break;
                  case 12: str = "Q"; break;
                  case 13: str = "K"; break;
                  case 14: str = "A"; break;
              default: str = i.ToString(); break;
              }
 
               Console.WriteLine($"{str} of spades, {str} of clubs, {str} of hearts, {str} of diamonds");
           }
        }
    }
}