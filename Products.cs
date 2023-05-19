using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Products
    {
        public string Name;
        public string Category;
        public int Price;
        public int Quantity;
        public int MinimumQuantity;
        public static List<Products> Stock = new List<Products>();
        public Products(string Name, string Category, int Price, int Quantity, int MinimumQuantity)
        {
            this.Name = Name;
            this.Category = Category;
            this.Price = Price;
            this.Quantity = Quantity;
            this.MinimumQuantity = MinimumQuantity;
        }
        public Products()
        {

        }
        
        public static void AddStock(Products s)
        {
            Stock.Add(s);
        }
        public  bool check(string category)
        {
            foreach (var i in Stock)
            {
                if (i.Category == category)
                {
                    return true;
                }
            }
            return false;
                 
        }
        public void Display(string category)
        {
               bool ispresent=check(category);
              if (ispresent == true)
            {
                Console.WriteLine("NAME\tPrice\tQuantity\tThreshold Qunatity");

                foreach (var i in Stock)
                {
                    if (i.Category == category)
                    {
                        Console.WriteLine("{0}{1}{2}{3}", i.Name, i.Price, i.Quantity, i.MinimumQuantity);
                        if(category== "grocery")
                        {
                            Console.WriteLine("Sales tax on {0} is 10% ", category);
                        }
                        else if(category == "fruit")
                        {
                            Console.WriteLine("Sales tax on {0} is 5% ", category);
                        }
                        else
                        {
                            Console.WriteLine("Sales tax on {0} is 15% ", category);
                        }

                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NO CATEGORY EXITS:");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        
    }
}
