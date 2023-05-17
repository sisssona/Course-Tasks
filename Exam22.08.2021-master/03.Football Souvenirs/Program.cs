using System;

namespace _03.Football_Souvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeam = Console.ReadLine();
            string souvenirType = Console.ReadLine();
            int countOfSouvenirs = int.Parse(Console.ReadLine());

            double sum = 0;

            if (footballTeam == "Argentina")
            {
                switch (souvenirType)
                {

                    case "flags":
                        sum = 3.25 * countOfSouvenirs;
                        break;
                    case "caps":
                        sum = 7.20 * countOfSouvenirs;
                        break;
                    case "posters":
                        sum = 5.10 * countOfSouvenirs;
                        break;
                    case "stickers":
                        sum = 1.25 * countOfSouvenirs;
                        break;
                }
            }
            else if (footballTeam == "Brazil")
            {
                switch (souvenirType)
                {
                    case "flags":
                        sum = 4.20 * countOfSouvenirs;
                        break;
                    case "caps":
                        sum = 8.50 * countOfSouvenirs;
                        break;
                    case "posters":
                        sum = 5.35 * countOfSouvenirs;
                        break;
                    case "stickers":
                        sum = 1.20 * countOfSouvenirs;
                        break;
                }

            }
            else if (footballTeam == "Croatia")
            {
                switch (souvenirType)
                {
                    case "flags":
                        sum = 2.75 * countOfSouvenirs;
                        break;
                    case "caps":
                        sum = 6.90 * countOfSouvenirs;
                        break;
                    case "posters":
                        sum = 4.95 * countOfSouvenirs;
                        break;
                    case "stickers":
                        sum = 1.10 * countOfSouvenirs;
                        break;
                }
            }
            else if (footballTeam == "Denmark")
            {
                switch (souvenirType)
                {
                    case "flags":
                        sum = 3.10 * countOfSouvenirs;
                        break;
                    case "caps":
                        sum = 6.50 * countOfSouvenirs;
                        break;
                    case "posters":
                        sum = 4.80 * countOfSouvenirs;
                        break;
                    case "stickers":
                        sum = 0.90 * countOfSouvenirs;
                        break;
                }

            }
            if (souvenirType != "flags" || souvenirType != "caps" || souvenirType != "posters" || souvenirType != "stickers"))
            {
                Console.WriteLine("Invalid stock!");
            }
            else if (footballTeam == "Argentina" || footballTeam == "Brazil" || footballTeam == "Croatia" || footballTeam == "Denmark")
            {
                Console.WriteLine($"Pepi bought {countOfSouvenirs} {souvenirType} of {footballTeam} for {sum:f2} lv.");
            }
            else if (footballTeam != "Argentina" || footballTeam != "Brazil" || footballTeam != "Croatia" || footballTeam != "Denmark")
            {
                Console.WriteLine("Invalid country!");
            }
           

        }
    }
}
