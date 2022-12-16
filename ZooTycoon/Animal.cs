using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTycoon
{
    public enum Gender
    {
        Male,
        Female
    }
    class Animal
    {
        public string AnimalName { 
            
            get
            {
                if (Age < MinAgeAdult)
                {
                    return AnimalChildName;
                }
                else
                {
                    return AnimalName;
                }
            }
            private set { }
        }
        public string AnimalChildName { private set; get; }
        public string Name { set; get; }
        private decimal coast = 0;
        public decimal Coast {
            private set
            {
                if (value >= 0M)
                {
                    coast = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Цена не должна быть меньше нуля!");
                }
            }
            get { return coast; }
        }
        public int Age { private set; get; }
        protected virtual int MinAgeAdult { set;  get; }
        private int satiety = 10;
        public int Satiety { 
            private set
            {
                if(Satiety < 10 && Satiety > 0)
                {
                    satiety = value;
                }
                if(Satiety <= 0)
                {
                    satiety = 0;
                }  
            }
            get 
            { return satiety; }
        }
        private int health = 10;
        public int Health 
        { 
            private set
            {
                if (Health < 10 && Health > 0)
                {
                    health = value;
                }
                if (Health <= 0)
                {
                    health = 0;
                }
            }
            get 
            { return health; }
        }
        public Gender AnimalGender { private set; get; }
        


        public Animal(string animalName, string animaChildName, string name, int minAgeAdult, decimal coast, Gender gender)
        {
            AnimalName = animalName;
            AnimalChildName = animaChildName;
            Name = name;
            MinAgeAdult = minAgeAdult;
            Coast = coast; 
            AnimalGender = gender;
            
        }

        public virtual void Feed(Food foodObj)
        { 
        }
        
        protected virtual void Eat(Food foodObj)
        {
            Console.WriteLine($"{AnimalName} {Name} сладко покушал {foodObj.Name}");
            Satiety++;
        }
        protected virtual void ThrowUp(Food foodObj)
        {
            Console.WriteLine($"{AnimalName} {Name} блеванул от {foodObj.Name}");
            Health--;
        }

        public void GrowUp()
        {
            Age++;
        }

    }
}
