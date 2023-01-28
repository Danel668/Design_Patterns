using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Shop
    {
        public abstract Salads CreateSalads(int _Weight);
    }

    public class OlivierShop : Shop
    {
        public override Salads CreateSalads(int _Weight)
        {
            Salads salad = new OlivierSalad(_Weight);
            Console.WriteLine($"OlivierSalad was created, weight: {_Weight}");
            return salad;
        }
    }

    public class CaesarShop : Shop
    {
        public override Salads CreateSalads(int _Weight)
        {
            Salads salad = new CaesarSalad(_Weight);
            Console.WriteLine($"CaesarSalad was created, weight: {_Weight}");
            return salad;
        }
    }

    public class CrabShop : Shop
    {
        public override Salads CreateSalads(int _Weight)
        {
            Salads salad = new CrabSalad(_Weight);
            Console.WriteLine($"CrabSalad was created , weight: {_Weight}");
            return salad;
        }
    }

    public class VinaigretteShop : Shop
    {
        public override Salads CreateSalads(int _Weight)
        {
            Salads salad = new VinaigretteSalad(_Weight);
            Console.WriteLine($"VinaigretteSalad was created , weight: {_Weight}");
            return salad;
        }
    }
}
