using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] token = command.Split();

                int serialNum = int.Parse(token[0]);
                string itemName = token[1];
                int itemQuantity = int.Parse(token[2]);
                decimal itemPrice = decimal.Parse(token[3]);

                Item newItem = new Item();
                newItem.Name = itemName;
                newItem.Price = itemPrice;

                Box newBox = new Box();
                newBox.SerialNumber = serialNum;
                newBox.Item = newItem;
                newBox.ItemQuantity = itemQuantity;
                newBox.BoxPrice = itemQuantity * itemPrice;

                boxes.Add(newBox);

                command = Console.ReadLine();
            }

            List<Box> orderedList = boxes.OrderByDescending(s => s.BoxPrice).ToList();

            foreach (var box in orderedList)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        public decimal BoxPrice { get; set; }
    }
}
