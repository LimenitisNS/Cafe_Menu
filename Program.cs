using System;

namespace Cafe_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafe menu = Cafe.SetMenu();
            Console.WriteLine(menu.ToString());
            Console.ReadKey();
        }
    }
}
