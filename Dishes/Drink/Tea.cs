using Cafe_Menu.Dishes.Drink.Interface;

namespace Cafe_Menu.Dishes.Drink
{
    public class Tea : IDrink
    {
        private string nameDish = "Tea";

        public string NameDrinkDish()
        {
            return nameDish;
        }
    }
}
