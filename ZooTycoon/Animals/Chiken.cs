﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon
{
    public class Chiken : Animal

    {
        public Chiken(string name, Gender gender) : base("курица", "ципленок", name, 2, 50M, gender)
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