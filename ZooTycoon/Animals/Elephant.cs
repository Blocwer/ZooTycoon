namespace ZooTycoon
{
    internal class Elephant:Animal
    {
        public Elephant(string name, Gender gender) :base("Слон","Слоненок", name, 500, gender , new TimeSpan(0,10,0))
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