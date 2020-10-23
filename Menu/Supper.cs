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
    class Supper : IMenu
    {
        public IMain main { get; } = new Yogurt();
        public ISalad salad { get; } = new Fruit();
        public IDessert dessert { get; } = new Cake();
        public IDrink drink { get; } = new Tea();

        public string GetMenu()
        {
            string menu = $"Supper:\n" +
                    $"Main: {main.NameMainDish()}\n" +
                    $"Salad: {salad.NameSaladDish()}\n" +
                    $"Dessert: {dessert.NameDessertDish()}\n" +
                    $"Drink: {drink.NameDrinkDish()}";
            return menu;
        }

    }
}
