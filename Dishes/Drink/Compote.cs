using Cafe_Menu.Dishes.Drink.Interface;

namespace Cafe_Menu.Dishes.Drink
{
    public class Compote : IDrink
    {
        private string nameDish = "Compote";

        public string NameDrinkDish()
        {
            return nameDish;
        }
    }
}
