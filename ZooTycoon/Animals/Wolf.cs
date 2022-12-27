﻿namespace ZooTycoon
{
    internal class Wolf:Animal
    {
        public Wolf(string name, Gender gender) :base("Волк","Волченок", name, 200, gender , new TimeSpan(0,4,0))
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