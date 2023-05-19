using System;


namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminDriverCode();


            Console.Read();
        }
        static void  AdminDriverCode()
        {
            while(true)
            {
                string choice = AdminMenu();
                if(choice=="1")
                {
                    AddProducts();
                }
                else if(choice=="2")
                {
                    Products s = new Products();
                    s.Display(CheckSpecificCategory());
                }
            }
        }
        static string AdminMenu()
        {
          
            Console.WriteLine("*********** Admin Menu ************");
            Console.WriteLine();
            Console.WriteLine("1-Add Products:");
            Console.WriteLine("2-View All Products:");
            Console.WriteLine("3-Find Product with Highest Unit Price.");
            Console.WriteLine("4-View Sales Tax of All Products.");
            Console.WriteLine("5-Products to be Ordered. (less than threshold");
            Console.WriteLine("6-Exit");
            Console.WriteLine("Enter Your Choice:");
            string choice = Console.ReadLine();
            return choice;
        }
        static void AddProducts()
        {
            string check = "u";
            while (true)
            {
                Console.Write("Enter Product Name:");
                string name = Console.ReadLine();
                Console.Write("Enter Product Category:");
                string categore = Console.ReadLine();
                Console.Write("Enter Product Price:");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Enter Available Stock Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                Console.Write("Enter Minimumn Stock threshold Quantity (after which the you want to order the product):");
                int minimum_quantity = int.Parse(Console.ReadLine());
                if (name != "" && categore != "" && price > 0 & quantity > 0 && minimum_quantity >= 0)
                {
                    Products s = new Products(name, categore, price, quantity, minimum_quantity);
                    Products.AddStock(s);
                    
                    Console.Write("Do you Want to add more items:(N for no and press any other key to continue:)");
                    check = Console.ReadLine().ToUpper();
                    if (check == "N")
                    {

                        break;
                      
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("PLEASE ENTER CORRECT INPUTS:");
                    Console.ForegroundColor = ConsoleColor.White;
                }

             


            }
           
        }
       static string CheckSpecificCategory()
        {
            Console.Write("Enter Category to show its list of Products(grocery,fruit,other):");
            string product = Console.ReadLine();
            return product;
        }
        

    }
}
