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
    public class Animal
    {

        private string animalName = "";
        public string AnimalName { 
            
            get
            {
                if (Age < MinAgeAdult)
                {
                    return AnimalChildName;
                }
                else
                {
                    return animalName;
                }
            }
            private set { animalName = value; }
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
        private DateTime dateBirthadayTime = DateTime.Now;
        private DateTime timeOfLastFeed = DateTime.Now;
        private DateTime whenSatietyDropZeroTime = DateTime.Now;

        private int age = 0;
        public  int Age  {  
        private set
        {
            if(Age < 1000 && Age >= 0)
            {
                age = value;
            }
            if(Age <= 0)
            {
                age = 0;
            }  
        }
        get 
        { return age; }
    }

        private int MinAgeAdult = 10;
        public TimeSpan TimeToGrowUp {private set; get; }
        private int satiety = 10  ;
        public int Satiety { 
            private set
            { 
                if(Satiety <= 10 && Satiety >= 0)
                {
                    if (value > 10)
                    {
                        satiety = 10;
                    }
                    else
                    {
                        satiety = value;
                    }
                    
                }
                if(Satiety <= 0 )
                {
                    satiety = 0;
                    whenSatietyDropZeroTime = TimeNow();
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
                if (Health <= 10 && Health > 0)
                {
                    if (value > 10)
                    {
                        health = 10;
                    }
                    else
                    {
                        health = value;
                    }
                    
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
        


        public Animal(string animalName, string animaChildName, string name, decimal coast, Gender gender, TimeSpan timeToGrowUp)
        {
            AnimalName = animalName;
            AnimalChildName = animaChildName;
            Name = name;
            Coast = coast; 
            AnimalGender = gender;
            TimeToGrowUp = timeToGrowUp;
        }

        public virtual void Feed(Food foodObj)
        {
        }
        
        protected virtual void Eat(Food foodObj)
        {
            Console.WriteLine($"{AnimalName} {Name} сладко покушал {foodObj.Name}");
            Satiety++;
            timeOfLastFeed = TimeNow();

        }
        protected virtual void ThrowUp(Food foodObj)
        {
            Console.WriteLine($"{AnimalName} {Name} блеванул от {foodObj.Name}");
            Health--;
        }
        DateTime TimeNow()
        {
            DateTime timeNow = DateTime.Now;
            return timeNow;
        }

        public void GrowUp()
        {
            
            TimeSpan time = (TimeNow().Subtract(dateBirthadayTime));
            int timeDivide = Convert.ToInt32(time / TimeToGrowUp);
            Age = timeDivide;
        }

        public void MinusSatiety()
        {
            TimeSpan time = (TimeNow().Subtract(timeOfLastFeed));
            int timeDivide = Convert.ToInt32(time /  new TimeSpan(0, 0, 2));
            Satiety = Satiety - timeDivide;
        }
 
        public void HungrySick()
        {
            TimeSpan time = (TimeNow().Subtract(whenSatietyDropZeroTime));
            int timeDivide = Convert.ToInt32(time / new TimeSpan(0, 0, 2));
            if (Satiety == 0)
            {
                Health = Health - timeDivide; 
            }
        }
    }
}
 