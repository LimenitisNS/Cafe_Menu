using Cafe_Menu.Dishes.Main.Interface;

namespace Cafe_Menu.Dishes.Main
{
    public class Porridge : IMain
    {
        private string nameDish = "Porridge";

        public string NameMainDish()
        {
            return nameDish;
        }
    }
}
