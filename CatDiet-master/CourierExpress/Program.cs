using System;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());

            double deliverySum = 0.0;

            if (type == "standard")
            {
                if (weight < 1)
                {
                    deliverySum = 0.03 * distance;
                }
                else if (weight < 10)
                {
                    deliverySum = 0.05 * distance;
                }
                else if (weight == 10 && weight < 40)
                {
                    deliverySum = 0.10 * distance;
                }
                else if (weight == 40 && weight < 90)
                {
                    deliverySum = 0.15 * distance;
                }
                else if (weight == 90 && weight < 150)
                {
                    deliverySum = 0.20 * distance;
                }
            }

            else if (type.Equals ("express"))
            {
                if (weight < 1)
                {
                    deliverySum = distance * 0.03 + (0.80 * 0.03 * weight * distance);
                }
                else if (weight < 10)
                {
                    deliverySum = distance * 0.05 + (0.40 * 0.05 * weight * distance);
                }
                else if (weight == 10 && weight < 40)
                {
                    deliverySum = distance * 0.10 + (0.05 * 0.10 * weight * distance);
                }
                else if (weight == 40 && weight < 90)
                {
                    deliverySum = distance * 0.15 + (0.02 * 0.15 * distance * weight);
                }
                else if (weight == 90 && weight < 150)
                {
                    deliverySum = distance * 0.20 + (0.01 * 0.20 * weight * distance);
                }
            }

                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {deliverySum:f2} lv.");

        }
    }
}
