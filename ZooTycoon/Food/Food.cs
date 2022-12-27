using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon
{
    public enum FoodList
    {
        Meat,
        Fruit,
        Vegetable,
        Seed
    }
    public class Food
    {
        public FoodList TypeFood { private set; get; }
        public string Name { set; get; }
        public decimal Coast { private set; get; }
        public Food(string name, FoodList typeFood, decimal coast )
        {
            Name = name;
            TypeFood = typeFood;
            Coast = coast;
        }
        
    }
}
