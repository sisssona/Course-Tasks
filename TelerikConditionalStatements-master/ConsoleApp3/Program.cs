using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            double paidPrice = double.Parse(Console.ReadLine());
            double change = paidPrice - price;
            change *= 100;
            double levs = 0; double stotinki50 = 0; double stotinki20 = 0; double stotinki10 = 0;
            double stotinki5 = 0; double stotinki2 = 0; double stotinki1 = 0.00;

            if (change >= 100)
            {
                levs = Math.Floor(change / 100);
                Console.WriteLine(levs + " x 1 lev");
                change = change - levs * 100;
            }
            if (change >= 50)
            {
                stotinki50 = Math.Floor(change / 50);
                Console.WriteLine(stotinki50 + " x 50 stotinki");
                change = change - stotinki50 * 50;
            }
            if (change >= 20)
            {
                stotinki20 = Math.Floor(change / 20);
                Console.WriteLine(stotinki20 + " x 20 stotinki");
                change = change - stotinki20 * 20;

            }
            if (change >= 10)
            {
                stotinki10 = Math.Floor(change / 10);
                Console.WriteLine(stotinki10 + " x 10 stotinki");
                change = change - stotinki10 * 10;
            }
            if (change >= 5)
            {
                stotinki5 = Math.Floor(change / 5);
                Console.WriteLine(stotinki5 + " x 5 stotinki");
                change = change - stotinki5 * 5;
            }
            if (change >= 2)
            {
                stotinki2 = Math.Floor(change / 2);
                Console.WriteLine(stotinki2 + " x 2 stotinki");
                change = change - stotinki2 * 2;

            }
            if (change >= 1)
            {
                stotinki1 = Math.Floor(change / 1);
                Console.WriteLine(stotinki1 + " x 1 stotinka");
                change = change - stotinki1 * 1;
            }




        }
    }
}
