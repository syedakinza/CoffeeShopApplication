using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop newShop = new CoffeeShop(30);
            Console.WriteLine("-----WELLCOME TO THE NEW COFFEE SHOP-----");
            Console.WriteLine("Initially we have "+newShop.TotalCups()+" cups"); 
            while (true)
            {
                Console.WriteLine("1-Customer\n2-Owner");
                Console.Write("Enter here : ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter your name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your contact number : ");
                    string cno = Console.ReadLine();
                    Console.Write("Enter number of cups you want : ");
                    int cups = int.Parse(Console.ReadLine());
                    if(newShop.newCustomer(name, cno, cups))
                    {
                        newShop.DisplayCustomerData();
                    }    
                }
                else if (choice == 2)
                {
                    Console.WriteLine("1-Want to add more coffee cups \n2-Show Total cups");
                    Console.Write("Enter here : ");
                    int c = int.Parse(Console.ReadLine());
                    if (c == 1)
                    {
                        Console.WriteLine("How many cups you want to add?");
                        Console.WriteLine("Enter amount : ");
                        int newCups = int.Parse(Console.ReadLine());
                        if (newShop.addCups(newCups))
                        {
                            Console.WriteLine("Cups are added successfully");
                        } 
                        else
                        {
                            Console.WriteLine("Sorry! Can't add cups. Enter valid amount of cups");
                        }
                    }
                    else if (c == 2)
                    {
                        Console.WriteLine("Total Coffee Cups are "+newShop.TotalCups());
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid Choice");
                    }
                }
                else
                {
                    break;
                }
            }
            

        }
    }
}
