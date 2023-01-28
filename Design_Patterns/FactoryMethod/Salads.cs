using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Salads
    {
        public string? Name { get; set; }
        public List<string>? Ingredients { get; set; }
        public string? ShelfLife { get; set; }
        public string? Sauce { get; set; }
        public int Weight { get; set; }
    }


    public class OlivierSalad : Salads
    {
        public OlivierSalad(int _Weight)
        {
            Name = "Olivier";
            Ingredients = new List<string> {
            "potatos", "eggs", "cucumbers", "sausage", "green peas"};
            Sauce = "Mayonnaise";
            ShelfLife = "5";
            Weight = _Weight;
        }
    }

    public class CaesarSalad : Salads
    {
        public CaesarSalad(int _Weight)
        {
            Name = "Caesar";
            ShelfLife = "4";
            Sauce = "Mayonnaise";
            Ingredients = new List<string>
            {
                "chicken", "cheese", "leaves", "crackers"
            };
            Weight = _Weight;

        }
    }

    public class CrabSalad : Salads
    {
        public CrabSalad(int _Weight)
        {
            Name = "Crab";
            ShelfLife = "3";
            Sauce = "Mayonnaise";
            Ingredients = new List<string>
            {
                "crab sticks", "eggs", "rice", "corn"
            };
            Weight = _Weight;

        }
    }

    public class VinaigretteSalad : Salads
    {
        public VinaigretteSalad(int _Weight)
        {
            Name = "Vinaigrette";
            ShelfLife = "5";
            Sauce = "olive oil";
            Ingredients = new List<string>
            {
                "beets", "onion", "potatos", "green peas"
            };
            Weight = _Weight;
        }
    }
}
