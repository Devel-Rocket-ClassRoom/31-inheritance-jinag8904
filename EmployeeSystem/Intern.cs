using System;

class Intern : Employee
{
    public Intern(string name) : base(name, 1500000)
    {

    }

    new public int CalculatePay() => _baseSalary;

    new public void PrintInfo()
    {
        Console.WriteLine($"[인턴] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}