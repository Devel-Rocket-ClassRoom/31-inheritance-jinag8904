using System;

class Manager : Employee
{
    protected int _bonus;

    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary)
    {
        _bonus = bonus;
    }

    new public int CalculatePay() => _baseSalary + _bonus;
    new public void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"보너스: {_bonus:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}
