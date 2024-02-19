using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm
{
    internal class Program { }
    

namespace ASM1
    {
        internal class Program
        {
            static string CustomerName()
            {
                Console.Write("Enter your name: ");
                return Console.ReadLine();
            }

            static int TypeOfCustomer()
            {
                Console.WriteLine("Type a customer:\n\t1. Household customer" +
                                  "\n\t2. Administrative agency, public services" +
                                  "\n\t3. Production units" +
                                  "\n\t4. Business services");
                int type;
                while (!int.TryParse(Console.ReadLine(), out type) || type < 1 || type > 4)
                {
                    Console.Write("Please enter a number from 1 to 4: ");
                }
                return type;
            }

            static double AmountOfConsumption()
            {
                Console.Write("Enter last month’s water meter readings: ");
                double lastWaterMeter;
                while (!double.TryParse(Console.ReadLine(), out lastWaterMeter))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                Console.Write("Enter this month’s water meter readings: ");
                double thisWaterMeter;
                while (!double.TryParse(Console.ReadLine(), out thisWaterMeter))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                return thisWaterMeter - lastWaterMeter;
            }

            static double CalculatePrice(int type, double consumption)
            {
                string typeOfCustomer;
                double price;

                switch (type)
                {
                    case 1:
                        typeOfCustomer = "Household customer";
                        if (consumption > 0 && consumption <= 10)
                        {
                            price = consumption * 5.973;
                        }
                        else if (consumption > 10 && consumption <= 20)
                        {
                            price = consumption * 7.052;
                        }
                        else if (consumption > 20 && consumption <= 30)
                        {
                            price = consumption * 8.699;
                        }
                        else
                        {
                            price = consumption * 15.929;
                        }
                        break;
                    case 2:
                        typeOfCustomer = "Administrative agency, public services";
                        price = consumption * 9.955;
                        break;
                    case 3:
                        typeOfCustomer = "Production units";
                        price = consumption * 11.615;
                        break;
                    case 4:
                        typeOfCustomer = "Business services";
                        price = consumption * 22.068;
                        break;
                    default:
                        return 0;
                }

                Console.WriteLine($"Water price for {typeOfCustomer} is: {price} VND/m3");
                return price;
            }

            static double TotalBill(double price)
            {
                double fee = price * 0.1;
                double totalBill = price + fee;
                Console.WriteLine($"Total water bill: {totalBill} VND");
                return totalBill;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("================= WATER BILLING PROGRAM =================\n");
                string name = CustomerName();
                Console.WriteLine($"\nWelcome {name} to the water billing program!!\n");
                Console.WriteLine("=========================================================");

                int type = TypeOfCustomer();
                double consumption = AmountOfConsumption();
                double price = CalculatePrice(type, consumption);
                TotalBill(price);
            }
        }
    }
}
        
        
    

