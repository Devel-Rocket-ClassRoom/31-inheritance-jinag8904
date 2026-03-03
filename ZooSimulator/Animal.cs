using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected string _sound;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void MakeSound() => Console.WriteLine($"{Name}: {_sound}");

    public void Eat() => Console.WriteLine($"{Name}(이)가 먹이를 먹습니다.");

    public void DisplayInfo() => Console.WriteLine($"이름: {Name}, 나이: {Age}살");
}

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age)
    {
        _sound = "으르렁!";
    }

    public void Hunt() => Console.WriteLine($"{Name}(이)가 사냥을 합니다.");
}

class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age)
    {
        _sound = "뿌우!";
    }

    public void SprayWater() => Console.WriteLine($"{Name}(이)가 물을 뿌립니다.");
}

class Penguin : Animal
{
    public Penguin(string name, int age) : base(name, age)
    {
        _sound = "꽥꽥!";
    }

    public void Swim() => Console.WriteLine($"{Name}(이)가 수영을 합니다.");
}