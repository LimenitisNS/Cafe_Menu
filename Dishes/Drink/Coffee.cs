using Cafe_Menu.Dishes.Drink.Interface;

namespace Cafe_Menu.Dishes.Drink
{
    public class Coffee : IDrink
    {
        private string nameDish = "Coffee";

        public string NameDrinkDish()
        {
            return nameDish;
        }
    }
}
