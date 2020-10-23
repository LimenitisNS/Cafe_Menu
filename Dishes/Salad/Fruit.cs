using Cafe_Menu.Dishes.Salad.Interface;

namespace Cafe_Menu.Dishes.Salad
{
    public class Fruit : ISalad
    {
        private string nameDish = "Fruit";

        public string NameSaladDish()
        {
            return nameDish;
        }
    }
}
