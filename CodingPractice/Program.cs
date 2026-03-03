using System;
using System.Diagnostics;

// 1-1.
{
    Child child = new Child();
    child.Greet();
    child.Study();
}
Console.WriteLine();

// 1-2.
{
    Dog dog = new Dog() { Name = "초코" };
    Cat cat = new Cat() { Name = "나비" };

    dog.Eat();
    dog.Bark();
    cat.Eat();
    cat.Meow();
}
Console.WriteLine();

// 2.
{
    Product product = new Product();
    Console.WriteLine(product.GetType());
    Console.WriteLine(product.ToString());
}
Console.WriteLine();

// 3.
{
    Child3 child = new Child3();
    child.ShowValues();
    Console.WriteLine(child.publicInt);
}
Console.WriteLine();

// 4.
{
    Manager manager = new Manager();
    manager.ShowDepartment();
    manager.ShowInfo();
}
Console.WriteLine();

// 5-1.
{
    Student student = new("홍길동", 3);
    Console.WriteLine($"이름: {student.Name}, 학년: {student.Grade}");
}
Console.WriteLine();

// 5-2.
{
    Dog5 dog = new Dog5();
}
Console.WriteLine();

{
    // 6-1.
    Animal6 animal = new Dog6() { Name = "멍멍이" };
    animal.Eat();

    Console.WriteLine();

    // 6-2.
    Dog6 dog = (Dog6) animal;
    dog.Bark();
}
Console.WriteLine();

// 6-3.
{
    Animal6 animal = new Dog6() { Name = "멍멍이" };

    if (animal is Dog6)
    {
        Dog6 dog = (Dog6) animal;
        dog.Bark();
    }
}
Console.WriteLine();

// 6-4.
{
    Animal6 animal = new Dog6() { Name = "멍멍이" };

    if (animal is Dog6 dog)
    {
        dog.Bark();
    }
}
Console.WriteLine();

// 6-5.
{
    Cat6 cat = new();
    Animal6 animal = cat;

    Dog6 dog = animal as Dog6;
    if (dog != null) dog.Bark();
    else Console.WriteLine($"Dog 타입이 아닙니다.");
}
Console.WriteLine();

// 7.
{
    Asset[] assets = new Asset[3]
    {
        new Stock {Name = "삼성전자"},
        new House {Name = "아파트"},
        new Stock {Name = "SK하이닉스"}
    };

    foreach (Asset asset in assets) Console.WriteLine(asset.Name);
}
Console.WriteLine();

// 8-1.
{
    Rectangle rectangle = new Rectangle()
    {
        Width = 25,
        Height = 2
    };

    Circle circle = new Circle()
    {
        radius = 3
    };

    rectangle.GetArea();
    circle.GetArea();
}
Console.WriteLine();

// 8-2.
{
    Car car = new();
    car.Start();
    car.Stop();
}
Console.WriteLine();

// 9.
{
    FinalClass finalClass = new();
    finalClass.Display();
}
Console.WriteLine();

// 10.
{
    Child10 child = new();
    Parent10 parent = child;
    
    Console.WriteLine($"child.Value: {child.Value}");
    Console.WriteLine($"parent.Value: {parent.Value}");

    child.Show();
    parent.Show();
}
Console.WriteLine();

// 11.
{
    Dog11 dog = new();

    Console.WriteLine(dog is Animal11);
    Console.WriteLine(dog is Dog11);
    Console.WriteLine(dog is Cat11);
}
Console.WriteLine();

// 12.
{
    GameCharacter[] characters =
    {
        new Warrior() { Name = "아서", Health = 150, Power = 25 },

        new Mage() { Name = "멀린", Health = 80, MagicPower = 40 },

        new Warrior() { Name = "란슬롯", Health = 150, Power = 30 }
};

    foreach (GameCharacter character in characters)
    {
        character.ShowStatus();
        character.Attack();

        Console.WriteLine();
    }
}

// 12.
abstract class GameCharacter
{
    public string Name { get; set; }
    public int Health { get; set; }

    abstract public void Attack();

    public void ShowStatus() => Console.WriteLine($"[{Name}] 체력: {Health}");
}

class Warrior : GameCharacter
{
    public int Power { get; set; }
    
    public override void Attack() => Console.WriteLine($"{Name}(이)가 검으로 {Power} 데미지를 입힙니다.");
}

class Mage : GameCharacter
{
    public int MagicPower { get; set; }

    public override void Attack() => Console.WriteLine($"{Name}(이)가 마법으로 {MagicPower} 데미지를 입힙니다.");
}

// 11.
class Animal11
{

}

class Dog11 : Animal11
{

}

class Cat11 : Animal11
{

}

// 10.
class Parent10
{
    public int Value = 10;

    public void Show() => Console.WriteLine("Parent.Show()");
}

class Child10 : Parent10
{
    new public int Value = 20;
    
    new public void Show() => Console.WriteLine("Child.Show()");
}

// 9.
sealed class FinalClass
{
    public void Display() => Console.WriteLine("이 클래스는 상속할 수 없다.");
}

// 8-2.
abstract class Vehicle
{
    abstract public void Start();

    public void Stop() => Console.WriteLine($"정지합니다.");
}

class Car : Vehicle
{
    override public void Start() => Console.WriteLine($"자동차 시동을 겁니다.");
}

// 8-1.
abstract class Shape
{
    public string Name;

    abstract public void GetArea();
}

class Rectangle : Shape
{
    public int Width;
    public int Height;

    public override void GetArea() => Console.WriteLine($"사각형 넓이: {Width * Height}");
}

class Circle : Shape
{
    public int radius;

    public override void GetArea() => Console.WriteLine($"원 넓이: {radius * radius * 3.14}");
}

// 7.
class Asset
{
    public string Name;
}

class Stock : Asset
{
    public int Shares;
}

class House : Asset
{
    public decimal Mortgage;
}

// 6-1 ~ 6-5.
class Animal6
{
    public string Name;

    public void Eat() => Console.WriteLine($"{Name}(이)가 먹습니다.");
}

class Dog6 : Animal6
{
    public void Bark() => Console.WriteLine($"{Name}(이)가 짖습니다.");
}

class Cat6 : Animal6
{
    public void Meow() => Console.WriteLine($"{Name}(이)가 웁니다.");
}

// 5-2.
class Animal5
{
    public Animal5()
    {
        Console.WriteLine("Animal 기본 생성자");
    }
}

class Dog5 : Animal5
{
    public Dog5()
    {
        Console.WriteLine("Dog 생성자");
    }
}

// 5-1.
class Person
{
    public string Name;
    
    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person 생성자 호출: {name}");
    }
}

class Student : Person
{
    public int Grade;

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
        Console.WriteLine($"Student 생성자 호출: {grade}학년");
    }
}

// 4.
class Employee
{
    protected string _department = "개발팀";

    public void ShowDepartment() => Console.WriteLine($"소속 부서: {_department}");
}

class Manager : Employee
{
    public void ShowInfo() => Console.WriteLine($"부서: {base._department}");
}

// 3.
class Parent3
{
    private int privateInt = 1;
    protected int protectedInt = 2;
    public int publicInt = 3;
}

class Child3 : Parent3
{
    public void ShowValues() => Console.WriteLine($"{protectedInt}, {publicInt}");
}

// 2.
class Product
{
    public string Name;
    public int Price;
}

// 1-2.
class Animal
{
    public string Name;
    public void Eat() => Console.WriteLine($"{Name}(이)가 먹이를 먹습니다.");
}

class Dog : Animal
{
    public void Bark() => Console.WriteLine($"{Name}(이)가 멍멍 짖습니다.");
}

class Cat : Animal
{
    public void Meow() => Console.WriteLine($"{Name}(이)가 야옹 웁니다.");
}

// 1-1.
class Parent
{
    public void Greet() => Console.WriteLine("안녕하세요!");
}

class Child : Parent
{
    public void Study() => Console.WriteLine("공부합니다.");
}