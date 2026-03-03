using System;

class Developer : Employee
{
    int _overtimeHours;

    public Developer(string name, int baseSalary, int overtimeHours) : base(name, baseSalary)
    {
        _overtimeHours = overtimeHours;
    }

    new public int CalculatePay() => _baseSalary + _overtimeHours * 20000;

    new public void PrintInfo()
    {
        Console.WriteLine($"[개발자] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"초과근무: {_overtimeHours}시간");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}