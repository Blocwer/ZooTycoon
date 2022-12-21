namespace ZooTycoon
{
    internal class Giraffe:Animal
    {
        public Giraffe(string name, Gender gender) :base("Жираф","Теленок жирафа", name, 3, 600M , gender)
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