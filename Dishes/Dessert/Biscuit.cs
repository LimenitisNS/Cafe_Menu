using Cafe_Menu.Dishes.Dessert.Interface;

namespace Cafe_Menu.Dishes.Dessert
{
    public class Biscuit : IDessert
    {
        private string nameDish = "Biscuit";

        public string NameDessertDish()
        {
            return nameDish;
        }
    }
}
