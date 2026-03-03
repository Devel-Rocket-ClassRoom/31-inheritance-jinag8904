using System;

Lion lion = new Lion("시바", 5);
Elephant ele = new Elephant("덤보", 10);
Penguin pen = new Penguin("뽀로로", 3);

Animal[] animals = { lion, ele, pen };

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

lion.Eat();
lion.Hunt();

ele.Eat();
ele.SprayWater();

pen.Eat();
pen.Swim();