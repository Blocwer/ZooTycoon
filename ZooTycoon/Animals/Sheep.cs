using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon
{
    internal class Sheep : Animal
    {

        public Sheep(string name, Gender gender) : base("Овца", "Овечка", name, 2, 140M, gender)
        {

        }

        public override void Feed(Food foodObj)
        {
            if (foodObj.TypeFood == FoodList.Seed)
                Eat(foodObj);
            else
                ThrowUp(foodObj);
        }
    }
}
