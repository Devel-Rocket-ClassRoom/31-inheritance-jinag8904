using System;

Animal[] animals = 
{
    new Lion("시바", 5),
    new Elephant("덤보", 10),
    new Penguin("뽀로로", 3)
};

Console.WriteLine("[동물 정보]");
foreach(var animal in animals)
{
    animal.DisplayInfo();
}

Console.WriteLine("\n[동물 소리]");
foreach (var animal in animals)
{
    animal.MakeSound();
}

Console.WriteLine("\n[동물 행동]");

animals[0].Eat();