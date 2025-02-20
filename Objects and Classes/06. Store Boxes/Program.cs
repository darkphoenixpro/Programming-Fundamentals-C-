﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes= new List<Box>();
            while (input!="end")
            {
                string[] inputInfo = input.Split(" ");
                string seriaNumber=inputInfo[0];
                string itemName=inputInfo[1];
                int itemQuantity = int.Parse(inputInfo[2]);
                decimal itemPrice=decimal.Parse(inputInfo[3]);
                Item item = new Item(itemName,itemPrice);
                Box box = new Box(seriaNumber, item, itemQuantity);
                boxes.Add(box);
                input = Console.ReadLine();
            }
            foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }

        }
    }
    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        
        public decimal Price { get; set; } 

    }
    public class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int Quantity { get; set; }

        public decimal PricePerBox 
        { 
            get
            {
                return Quantity*Item.Price;
            }
            set
            {

            }
        }
    }
}
