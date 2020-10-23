using Cafe_Menu.Dishes.Main;
using Cafe_Menu.Dishes.Salad;
using Cafe_Menu.Dishes.Dessert;
using Cafe_Menu.Dishes.Drink;
using Cafe_Menu.Dishes.Dessert.Interface;
using Cafe_Menu.Dishes.Drink.Interface;
using Cafe_Menu.Dishes.Main.Interface;
using Cafe_Menu.Dishes.Salad.Interface;
using Cafe_Menu.Menu.Interface;

namespace Cafe_Menu.Menu
{
    class Lunch : IMenu
    {
        public IMain main { get; } = new Pasta();
        public ISalad salad { get; } = new Vegies();
        public IDessert dessert { get; } = new Biscuit();
        public IDrink drink { get; } = new Compote();

        public string GetMenu()
        {
            string menu = $"Lunch:\n" +
                    $"Main: {main.NameMainDish()}\n" +
                    $"Salad: {salad.NameSaladDish()}\n" +
                    $"Dessert: {dessert.NameDessertDish()}\n" +
                    $"Drink: {drink.NameDrinkDish()}";
            return menu;
        }
    }
}
