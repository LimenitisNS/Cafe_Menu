using Cafe_Menu.Dishes.Main.Interface;

namespace Cafe_Menu.Dishes.Main
{
    public class Yogurt : IMain
    {
        private string nameDish = "Yogurt";

        public string NameMainDish()
        {
            return nameDish;
        }
    }
}
