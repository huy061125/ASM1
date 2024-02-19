using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    internal class Program
    {
        static string CustomerName()
        {
            Console.Write("Enter your name: ");
            string customerName = Console.ReadLine();
            return customerName;
        }
        //choose customer type
        static int TypeOfCustomer()
        {

            Console.WriteLine("Type a customer:\n\t1. Household customer " +
                "                               \n\t2. Administrative agency, public services " +
                "                               \n\t3. Production units" +
                "                               \n\t4. Business services");
            Console.Write("Enter your type (1-4): ");
            int type = int.Parse(Console.ReadLine());

            while (type < 1 || type > 4)
            {
                Console.Write("Please enter a number from 1 to 4:");
                type = int.Parse(Console.ReadLine());
            }
            return type;
        }
        //Calculate consumption
        static double AmountOfConsumption()
        {
            Console.Write("Enter last month’s water meter readings: ");
            double lastWateMeter = double.Parse(Console.ReadLine());

            Console.Write("Enter this month’s water meter readings: ");
            double thisWateMeter = double.Parse(Console.ReadLine());

            double consumptuion = thisWateMeter - lastWateMeter;
            return consumptuion;
        }

        //Calculate prices based on customer type
        static double Price()
        {
            int type = TypeOfCustomer();
            string typeOfCustomer;
            double price = default;
            double consumption = AmountOfConsumption();
            switch (type)
            {
                case 1:
                    typeOfCustomer = "Household customer";
                    if (consumption > 0 && consumption <= 10)
                    {
                        price = (consumption * 5.973);
                        Console.WriteLine($"Water price for {typeOfCustomer} is: 5.973 VND/m3");

                    }
                    else if (consumption > 10 && consumption <= 20)
                    {
                        price = (consumption * 7.052);
                        Console.WriteLine($"Water price for {typeOfCustomer} is: 7.052 VND/m3");

                    }
                    else if (consumption > 20 && consumption <= 30)
                    {
                        price = (consumption * 8.699);
                        Console.WriteLine($"Water price for {typeOfCustomer} is: 8.699 VND/m3");

                    }
                    else
                    {
                        price = (consumption * 15.929);
                        Console.WriteLine($"Water price for {typeOfCustomer} is: 15.929 VND/m3");
                    }
                    break;
                case 2:
                    typeOfCustomer = "Administrative agency, public services";
                    price = (consumption * 9.955);
                    Console.WriteLine($"Water price for {typeOfCustomer} is: 9.955 VND/m3");
                    break;
                case 3:
                    typeOfCustomer = "Production units";
                    price = (consumption * 11.615);
                    Console.WriteLine($"Water price for {typeOfCustomer} is: 11.615 VND/m3");
                    break;
                case 4:
                    typeOfCustomer = "Business services";
                    price = (consumption * 22.068);
                    Console.WriteLine($"Water price for {typeOfCustomer} is: 22.068 VND/m3");
                    break;
                default:
                    return 0;
            }
            return price;
        }
        //Calculate totalBill based on price and VAT
        static double TotalBill()
        {
            double price = Price();
            double fee = price * 0.01;
            double totalBill = price + fee;
            Console.WriteLine($"Total water bill: {totalBill} VND ");
            return totalBill;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("================= WATER BILLING PROGRAM =================\n");
            string name = CustomerName();
            Console.WriteLine($"\nWelcome {name} to the water billing program!!\n");
            Console.WriteLine("=========================================================");
            TotalBill();
        }
    }
}
    
  



