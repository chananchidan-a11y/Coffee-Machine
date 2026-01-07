using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine
{
    internal class Program
    {
        class IngredientStock
        {
            public int Water { get; set; } = 1000;
            public int Coffee { get; set; } = 200;
            public int Milk { get; set; } = 100;
            public int Chocolate { get; set; } = 100;

            public void Refill()
            {
                Water += 1000;
                Coffee += 200;
                Milk += 100;
                Chocolate += 100;
                Console.WriteLine("เติมวัตถุดิบเรียบร้อย");
            }
        }

        class Drink
        {
            public string Name { get; set; }
            public int Water { get; set; }
            public int Coffee { get; set; }
            public int Milk { get; set; }
            public int Chocolate { get; set; }
        }

        class CoffeeMachine
        {
            private IngredientStock stock;

            public CoffeeMachine(IngredientStock stock)
            {
                this.stock = stock;
            }

            public bool CanMake(Drink drink)
            {
                return stock.Water >= drink.Water &&
                       stock.Coffee >= drink.Coffee &&
                       stock.Milk >= drink.Milk &&
                       stock.Chocolate >= drink.Chocolate;
            }

            public void MakeDrink(Drink drink)
            {
                if (!CanMake(drink))
                {
                    Console.WriteLine("วัตถุดิบไม่เพียงพอ กำลังเติม...");
                    stock.Refill();
                }

                stock.Water -= drink.Water;
                stock.Coffee -= drink.Coffee;
                stock.Milk -= drink.Milk;
                stock.Chocolate -= drink.Chocolate;

                Console.WriteLine($"ชง {drink.Name} เสร็จเรียบร้อย ☕");
            }
        }
        static void Main()
        {
            IngredientStock stock = new IngredientStock();
            CoffeeMachine machine = new CoffeeMachine(stock);

            Dictionary<int, Drink> menu = new Dictionary<int, Drink>()
        {
            {1, new Drink { Name="กาแฟดำ", Water=300, Coffee=20 }},
            {2, new Drink { Name="มอคค่า", Water=300, Coffee=20, Chocolate=10 }},
            {3, new Drink { Name="ลาเต้", Water=300, Coffee=20, Milk=10 }},
            {4, new Drink { Name="ช็อกโกแลต", Water=300, Chocolate=20 }}
        };

            while (true)
            {
                Console.WriteLine("\n===== เมนูเครื่องดื่ม =====");
                Console.WriteLine("1. กาแฟดำ");
                Console.WriteLine("2. มอคค่า");
                Console.WriteLine("3. ลาเต้");
                Console.WriteLine("4. ช็อกโกแลต");
                Console.WriteLine("0. ออกจากโปรแกรม");
                Console.Write("เลือกเมนู: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0) break;

                if (menu.ContainsKey(choice))
                {
                    machine.MakeDrink(menu[choice]);
                }
                else
                {
                    Console.WriteLine("เลือกเมนูไม่ถูกต้อง");
                }
            }
        }
    }
}


        
        
    

