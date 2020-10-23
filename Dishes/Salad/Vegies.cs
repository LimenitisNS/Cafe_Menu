using Cafe_Menu.Dishes.Salad.Interface;

namespace Cafe_Menu.Dishes.Salad
{
    public class Vegies : ISalad
    {
        private string nameDish = "Vegies";

        public string NameSaladDish()
        {
            return nameDish;
        }
    }
}
