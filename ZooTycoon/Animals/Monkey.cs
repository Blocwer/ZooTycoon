namespace ZooTycoon
{
    internal class Monkey:Animal
    {
        public Monkey(string name, Gender gender) :base("Обезьяна","Обезьянка", name, 300M, gender ,new TimeSpan(0,7,0))
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