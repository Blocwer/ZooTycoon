using ZooTycoon;
Animal giraffe = new Giraffe("Rafik", Gender.Male);

giraffe.Feed(new Banana());

Console.WriteLine($" сытость {giraffe.Satiety}");  



Console.ReadKey();
giraffe.GrowUp();
giraffe.MinusSatiety(); 
Console.WriteLine($" возраст{giraffe.Age}");
Console.WriteLine($"здоровье {giraffe.Health}");
Console.WriteLine($" сытость {giraffe.Satiety}");
Console.ReadKey();

Console.WriteLine($" возраст{giraffe.Age}");
giraffe.Feed(new ChikenFood());
Console.WriteLine($"здоровье {giraffe.Health}");
     



  
giraffe.MinusSatiety();
giraffe.HungrySick();
Console.WriteLine($" возраст{giraffe.Age}");
Console.WriteLine($" сытость {giraffe.Satiety}");
Console.WriteLine($"здоровье {giraffe.Health}");
  


 
  

