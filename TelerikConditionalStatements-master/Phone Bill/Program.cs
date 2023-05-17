using System;

namespace Phone_Bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMessages = int.Parse(Console.ReadLine());
            int totalMinutes = int.Parse(Console.ReadLine());

            double tax = 12.00;
            double additionalMessageTax = 0;
            double messages = totalMessages - 20;
            double additionalMinutesTax = 0;
            double minutes = totalMinutes - 60;
            double salesTax = 0.2;

            if (totalMessages > 20)
            {
                additionalMessageTax = messages * 0.06;
                
            }
            if (totalMinutes > 60)
            {
                additionalMinutesTax = minutes * 0.10;
            }
            double totalSalesTax = (salesTax * additionalMessageTax) + (salesTax * additionalMinutesTax);
            double totalBill = tax + additionalMessageTax + additionalMinutesTax + totalSalesTax;

            Console.WriteLine($"{messages} additional messages for {additionalMessageTax:f2} levas");
            Console.WriteLine($"{minutes} additional minutes for {additionalMinutesTax:f2} levas");
            Console.WriteLine($"{totalSalesTax:f2} additional taxes");
            Console.WriteLine($"{totalBill:f2} total bill");

        }
    }
}
