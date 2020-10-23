using Cafe_Menu.Dishes.Dessert.Interface;
using Cafe_Menu.Dishes.Drink.Interface;
using Cafe_Menu.Dishes.Main.Interface;
using Cafe_Menu.Dishes.Salad.Interface;

namespace Cafe_Menu.Menu.Interface
{
    public interface IMenu
    {
        IMain main { get; }
        ISalad salad { get; }
        IDessert dessert { get; }
        IDrink drink { get; }

        string GetMenu();
    }
}
