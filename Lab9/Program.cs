namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenu basicMenu = new BasicMenu();

            SeasonalMenuDecorator seasonalMenu = new SeasonalMenuDecorator(basicMenu);
            seasonalMenu.AddSeasonalItem("Салат зі свіжих овочів");
            seasonalMenu.AddSeasonalItem("Фруктовий десерт");

            DailySpecialsDecorator menuWithSpecial = new DailySpecialsDecorator(seasonalMenu, "Стейк зі свинини з гарніром");

            menuWithSpecial.Display();
        }
    }
    
}
