using System;

namespace Calculate_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double discount = 0.65;
            double discountPrice = 0;
            double priceAfterDiscount = 0;

            for (int i = 0; i < n; i++)
            {
                double itemPrice = double.Parse(Console.ReadLine());
                discountPrice = itemPrice - (itemPrice * discount);
                priceAfterDiscount = discountPrice;
                Console.WriteLine($"{Math.Abs(priceAfterDiscount):f2}");
            }
        }
    }
}
