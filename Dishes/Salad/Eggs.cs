using Cafe_Menu.Dishes.Salad.Interface;

namespace Cafe_Menu.Dishes.Salad
{
    public class Eggs : ISalad
    {
        private string nameDish = "Eggs";

        public string NameSaladDish()
        {
            return nameDish;
        }
    }
}
