using System;
using Cafe_Menu.Menu.Interface;
using Cafe_Menu.Menu;

namespace Cafe_Menu
{
    class Cafe
    {
        private static Cafe instance;
        private static object syncRoot = new Object();
        private static IMenu menu;

        private Cafe()
        {
            Console.WriteLine("1: Breakfast\n2: Lunch\n3: Supper");

            int mealTime;
            do
            {
                Console.Write("Select a submenu: ");
                string stringMealTime = Console.ReadLine();
                mealTime = Convert.ToInt32(stringMealTime);
                Console.WriteLine();

            } while (mealTime != 1 && mealTime != 2 && mealTime != 3);

            switch (mealTime)
            {
                case 1:
                    menu = new Breakfast();
                    break;

                case 2:
                    menu = new Lunch();
                    break;

                case 3:
                    menu = new Supper();
                    break;
            }
        }

        public static Cafe SetMenu()
        {
            if (instance == null)
            {
                lock(syncRoot)
                {
                    if(instance == null)
                    {
                        instance = new Cafe();
                    }
                }
            }

            return instance;
        }

        public override string ToString()
        {
            return (menu.GetMenu() + "\n");
        }
    }
}
