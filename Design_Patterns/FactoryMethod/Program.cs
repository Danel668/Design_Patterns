using static System.Console;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop1 = new OlivierShop();
            Shop shop2 = new CaesarShop();
            Shop shop3 = new CrabShop();
            Shop shop4 = new VinaigretteShop();

            Salads salad1 = shop1.CreateSalads(100);
            Salads salad2 = shop2.CreateSalads(150);
            Salads salad3 = shop3.CreateSalads(200);
            Salads salad4 = shop4.CreateSalads(500);

            ReadKey();
        }
    }
}