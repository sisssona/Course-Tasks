using System;using System.Threading.Tasks;namespace _11._Number_as_Words{    class Program    {        static void Main(string[] args)        {            int number = int.Parse(Console.ReadLine());            int hundreds = number / 100 | 0;            int onesAndTens;            if (number > 99) onesAndTens = number % 100;            else onesAndTens = number * 1;            int ones = number % 10;            switch (hundreds)            {                case 1: Console.Write("One hundred "); break;                case 2: Console.Write("Two hundred "); break;                case 3: Console.Write("Three hundred "); break;                case 4: Console.Write("Four hundred "); break;                case 5: Console.Write("Five hundred "); break;                case 6: Console.Write("Six hundred "); break;                case 7: Console.Write("Seven hundred "); break;                case 8: Console.Write("Eight hundred "); break;                case 9: Console.Write("Nine hundred "); break;            }            if (hundreds >= 1 && onesAndTens >= 1) Console.WriteLine("and");            if (onesAndTens >= 20 && onesAndTens < 30) Console.Write("Twenty");            else if (onesAndTens >= 30 && onesAndTens < 40) Console.Write("Thirty");            else if (onesAndTens >= 40 && onesAndTens < 50) Console.Write("Fourty");            else if (onesAndTens >= 50 && onesAndTens < 60) Console.Write("Fifty");            else if (onesAndTens >= 60 && onesAndTens < 70) Console.Write("Sixty");            else if (onesAndTens >= 70 && onesAndTens < 80) Console.Write("Seventy");            else if (onesAndTens >= 80 && onesAndTens < 90) Console.Write("Eighty");            else if (onesAndTens >= 90 && onesAndTens < 100) Console.Write("Ninety");

            switch (onesAndTens)
            {
                
                case 1: Console.WriteLine("One"); break;
                case 2: Console.WriteLine("Two"); break;
                case 3: Console.WriteLine("Three"); break;
                case 4: Console.WriteLine("Four"); break;
                case 5: Console.WriteLine("Five"); break;
                case 6: Console.WriteLine("Six"); break;
                case 7: Console.WriteLine("Seven"); break;
                case 8: Console.WriteLine("Eight"); break;
                case 9: Console.WriteLine("Nine"); break;
                case 10: Console.WriteLine("Ten"); break;
                case 11: Console.WriteLine("Eleven"); break;
                case 12: Console.WriteLine("Twelve"); break;
                case 13: Console.WriteLine("Thirteen"); break;
                case 14: Console.WriteLine("Fourteen"); break;
                case 15: Console.WriteLine("Fivteen"); break;
                case 16: Console.WriteLine("Sixteen"); break;
                case 17: Console.WriteLine("Seventeen"); break;
                case 18: Console.WriteLine("Eighteen"); break;
                case 19: Console.WriteLine("Nineteen"); break;
                default:
                    break;
            }
            if (onesAndTens > 20)
            {
                switch (ones)
                {
                    case 1: Console.Write("-one"); break;
                    case 2: Console.Write("-two"); break;
                    case 3: Console.Write("-three"); break;
                    case 4: Console.Write("-four"); break;
                    case 5: Console.Write("-five"); break;
                    case 6: Console.Write("-six"); break;
                    case 7: Console.Write("-seven"); break;
                    case 8: Console.Write("-eight"); break;
                    case 9: Console.Write("-nine"); break;
                }

            }
            if (number == 0) Console.Write("Zero");
            
        }
    }

}