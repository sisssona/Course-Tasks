using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item = itemName;
                box.Quantity = itemQuantity;
                box.PriceBox = itemPrice;
                box.TotalPrice = itemQuantity * itemPrice;
                boxes.Add(box);

                line = Console.ReadLine();

               
            }
            List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.TotalPrice).ToList();
            foreach (Box box in sortedBox)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item} - ${box.PriceBox:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.TotalPrice:f2}");

            }

        }
    }
    class Box
    {
        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceBox { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
