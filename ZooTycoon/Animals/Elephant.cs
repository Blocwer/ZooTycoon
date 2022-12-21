namespace ZooTycoon
{
    internal class Elephant:Animal
    {
        public Elephant(string name, Gender gender) :base("Слон","Слоненок", name, 5, 500M , gender)
        {   
        }
        public override void Feed(Food foodObj)
        {
            if (foodObj.TypeFood == FoodList.Fruit)
                Eat(foodObj);
            else
                ThrowUp(foodObj);
        }

    }
}