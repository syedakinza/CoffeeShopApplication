using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApplication
{
    class CoffeeShop
    {
        double noOfCups, cusCups;
        string name, contactno;
        double billAmount;
        public CoffeeShop(double noOfCups)
        {
            this.noOfCups = noOfCups;
        }
        public bool addCups(double Cups)
        {
            if (Cups > 0)
            {
                this.noOfCups += Cups;
                return true;
            }
            else
            {
                return false;
            }

        }
        public void supplyCups(int Cups)
        {
            this.noOfCups -= Cups;
        }
        public bool newCustomer(string name,string contactno,int cups)
        {
            if (cups <= this.noOfCups)
            {
                this.name = name;
                this.contactno = contactno;
                this.cusCups = cups;
                supplyCups(cups);
                this.billAmount = CalculateBill(cups);
                return true;
            }
            else
            {
                Console.WriteLine("We are sorry! We don't have " + cups + " cups of coffee.");
                return false;
            }
        }
        public double CalculateBill(int cups)
        {
            return cups * 120;
        }
        public double TotalCups()
        {
            return this.noOfCups;
        }

        public void DisplayCustomerData()
        {
            Console.WriteLine("Name : "+this.name);
            Console.WriteLine("Contact Number : "+this.contactno);
            Console.WriteLine("No of Coffee Cups : "+this.cusCups);
            Console.WriteLine("Total bill : " + this.billAmount);
        }
    }
}
