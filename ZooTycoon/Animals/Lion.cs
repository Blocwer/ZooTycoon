namespace ZooTycoon
{
    internal class Lion:Animal
    {
        public Lion(string name, Gender gender) :base("Лев","Львенок", name, 4, 1000M , gender)
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