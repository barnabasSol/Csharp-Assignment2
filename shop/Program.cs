using System;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buying = true;
            string choice;
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
                choice = Console.ReadLine();
                bool isNumber = int.TryParse(choice, out _);
                while (!isNumber)
                {
                    Console.Write("invalid input, try again: ");
                    choice = Console.ReadLine();
                    isNumber = int.TryParse(choice, out _);
                }
                if (int.Parse(choice) > 5 || int.Parse(choice) < 1)
                {
                    Console.WriteLine("we dont have that item");
                    Console.WriteLine("press any key to continue shopping....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (int.Parse(choice) == 1)
                {
                    ++amnt_item1;
                    sumTotal += 30.00;
                    Console.WriteLine("added to cart!");
                    Console.WriteLine("press any key to continue shopping....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (int.Parse(choice) == 2)
                {
                    ++amnt_item2;
                    sumTotal += 22.50;
                    Console.WriteLine("added to cart!");
                    Console.WriteLine("press any key to continue shopping....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (int.Parse(choice) == 3)
                {
                    ++amnt_item3;
                    sumTotal += 5.00;
                    Console.WriteLine("added to cart!");
                    Console.WriteLine("press any key to continue shopping....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (int.Parse(choice) == 4)
                {
                    amnt_item4++;
                    sumTotal += 51.00;
                    Console.WriteLine("added to cart!");
                    Console.WriteLine("press any key to continue shopping....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (int.Parse(choice) == 5)
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
                Console.WriteLine("ITEM- - - - - - - -AMOUNT");
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
