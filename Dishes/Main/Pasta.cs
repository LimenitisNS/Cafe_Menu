using Cafe_Menu.Dishes.Main.Interface;

namespace Cafe_Menu.Dishes.Main
{
    public class Pasta : IMain
    {
        private string nameDish = "Pasta";

        public string NameMainDish()
        {
            return nameDish;
        }
    }
}
