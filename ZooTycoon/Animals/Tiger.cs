using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon
{
    internal class Tiger:Animal
    {
        public Tiger(string name, Gender gender) :base("Тигр","Тигренок", name, 3, 300M , gender)
        {   
        }
        public override void Feed(Food foodObj)
        {
            if (foodObj.TypeFood == FoodList.Meat)
                Eat(foodObj);
            else
                ThrowUp(foodObj);
        }

    }
}
