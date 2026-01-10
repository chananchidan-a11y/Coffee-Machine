using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_CoffeeMachine
{
        class Program
        {
            static void Main(string[] args)
            {
                // สร้างเครื่องชงกาแฟ พร้อมวัตถุดิบเริ่มต้น
                CoffeeMachine machine = new CoffeeMachine(2000, 500, 300, 300);

                while (true)
                {
                    Console.WriteLine("\n===== Automatic Coffee Machine =====");
                    Console.WriteLine("1. Black Coffee");
                    Console.WriteLine("2. Mocha");
                    Console.WriteLine("3. Latte");
                    Console.WriteLine("4. Chocolate");
                    Console.WriteLine("5. Show stock");
                    Console.WriteLine("6. Refill ingredients");
                    Console.WriteLine("0. Exit");
                    Console.Write("Select menu: ");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            machine.MakeBlackCoffee();
                            break;
                        case "2":
                            machine.MakeMocha();
                            break;
                        case "3":
                            machine.MakeLatte();
                            break;
                        case "4":
                            machine.MakeChocolate();
                            break;
                        case "5":
                            machine.ShowStock();
                            break;
                        case "6":
                            machine.Refill();
                            break;
                        case "0":
                            Console.WriteLine("Thank you for using the coffee machine.");
                            return;
                        default:
                            Console.WriteLine("Invalid menu. Please try again.");
                            break;
                    }
                }
            }
        }

        // ===== CoffeeMachine Class =====
        class CoffeeMachine
        {
            int water;
            int coffee;
            int milk;
            int chocolate;

            // Constructor
            public CoffeeMachine(int water, int coffee, int milk, int chocolate)
            {
                this.water = water;
                this.coffee = coffee;
                this.milk = milk;
                this.chocolate = chocolate;
            }

            public void MakeBlackCoffee()
            {
                if (water >= 300 && coffee >= 20)
                {
                    water -= 300;
                    coffee -= 20;
                    Console.WriteLine("Black coffee is ready ");
                }
                else
                {
                    Console.WriteLine("Not enough ingredients for Black Coffee.");
                }
            }

            public void MakeMocha()
            {
                if (water >= 300 && coffee >= 20 && chocolate >= 10)
                {
                    water -= 300;
                    coffee -= 20;
                    chocolate -= 10;
                    Console.WriteLine("Mocha is ready ");
                }
                else
                {
                    Console.WriteLine("Not enough ingredients for Mocha.");
                }
            }

            public void MakeLatte()
            {
                if (water >= 300 && coffee >= 20 && milk >= 10)
                {
                    water -= 300;
                    coffee -= 20;
                    milk -= 10;
                    Console.WriteLine("Latte is ready ");
                }
                else
                {
                    Console.WriteLine("Not enough ingredients for Latte.");
                }
            }

            public void MakeChocolate()
            {
                if (water >= 300 && chocolate >= 20)
                {
                    water -= 300;
                    chocolate -= 20;
                    Console.WriteLine("Chocolate drink is ready ");
                }
                else
                {
                    Console.WriteLine("Not enough ingredients for Chocolate.");
                }
            }

            public void ShowStock()
            {
                Console.WriteLine("\n---- Current Stock ----");
                Console.WriteLine("Water: " + water + " g");
                Console.WriteLine("Coffee: " + coffee + " g");
                Console.WriteLine("Milk: " + milk + " g");
                Console.WriteLine("Chocolate: " + chocolate + " g");
            }

            public void Refill()
            {
                water += 500;
                coffee += 100;
                milk += 100;
                chocolate += 100;
                Console.WriteLine("Ingredients refilled successfully.");
                ShowStock();
            }
        }
    }

        
        
    
