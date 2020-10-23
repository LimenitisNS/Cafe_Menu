using Cafe_Menu.Dishes.Dessert.Interface;

namespace Cafe_Menu.Dishes.Dessert
{
    public class Pancake : IDessert
    {
        private string nameDish = "Pancake";

        public string NameDessertDish()
        {
            return nameDish;
        }
    }
}
