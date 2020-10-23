using Cafe_Menu.Dishes.Dessert.Interface;

namespace Cafe_Menu.Dishes.Dessert
{
    public class Cake : IDessert
    {
        private string nameDish = "Cake";

        public string NameDessertDish()
        {
            return nameDish;
        }
    }
}
