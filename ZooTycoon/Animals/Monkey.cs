namespace ZooTycoon
{
    internal class Monkey:Animal
    {
        public Monkey(string name, Gender gender) :base("Обезьяна","Обезьянка", name, 2, 300M , gender)
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