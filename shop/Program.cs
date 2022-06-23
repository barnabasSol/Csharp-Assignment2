using System;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buying = true;
            int choice;
            double sumTotal = 0;
            int amnt_item1 = 0;
            int amnt_item2 = 0;
            int amnt_item3 = 0;
            int amnt_item4 = 0;
            while (buying)
            {
                Console.WriteLine("------ --- Shop --- ------");
                Console.WriteLine("1, shovel----30.00 birr");
                Console.WriteLine("2, wrench----22.50 birr");
                Console.WriteLine("3, knife----5.00 birr");
                Console.WriteLine("4, boiling flask----51.00 birr");
                Console.WriteLine("5, exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 5 || choice < 1)
                {
                    Console.WriteLine("we dont have that item");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 1)
                {
                    ++amnt_item1;
                    sumTotal += 30;
                    Console.WriteLine("added to cart!");
                    Console.WriteLine("press any key to continue....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 2)
                {
                    ++amnt_item2;
                    sumTotal += 22.5;
                    Console.WriteLine("added to cart!");
                    Console.WriteLine("press any key to continue....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 3)
                {
                    ++amnt_item3;
                    sumTotal += 5;
                    Console.WriteLine("added to cart!");
                    Console.WriteLine("press any key to continue....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 4)
                {
                    amnt_item4++;
                    sumTotal += 51;
                    Console.WriteLine("added to cart!");
                    Console.WriteLine("press any key to continue....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice == 5)
                {
                    buying = false;
                }
            }
            if (sumTotal == 0)
            {
                Console.WriteLine("you didn't buy anything, maybe next time!");
            }
            else
            {
                Console.WriteLine("ITEM _ _ _ _ _ _ _AMOUNT");
                Console.WriteLine();
                if (amnt_item1 > 0)
                {
                    Console.WriteLine("shovel_ _ _ _ _ _ _ _" + amnt_item1);
                }
                if (amnt_item2 > 0)
                {
                    Console.WriteLine("wrench_ _ _ _ _ _ _ _" + amnt_item2);
                }
                if (amnt_item3 > 0)
                {
                    Console.WriteLine("knife _ _ _ _ _ _ _ _" + amnt_item3);
                }
                if (amnt_item4 > 0)
                {
                    Console.WriteLine("boiling flask_ _ _ _ " + amnt_item4);
                }
                Console.WriteLine();
                Console.WriteLine("Sum total price is: " + sumTotal + " birr");
            }
        }
    }
}
