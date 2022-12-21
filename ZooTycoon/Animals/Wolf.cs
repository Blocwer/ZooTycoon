namespace ZooTycoon
{
    internal class Wolf:Animal
    {
        public Wolf(string name, Gender gender) :base("Волк","Волченок", name, 3, 200M , gender)
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