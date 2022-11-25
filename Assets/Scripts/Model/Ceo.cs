using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceo : Employee
{
    public Ceo(EnumSeniority seniority) : base(seniority)
    {
        baseSalary = 20000f;
    }

    public Ceo()
    {
        baseSalary = 20000f;
    }

    public float Salary { get => salary; }
    public EnumSeniority Seniority { get => seniority; }


    public override float salaryIncrement()
    {
        salary = baseSalary;
        salary += salary;
        return salary;
    }
}
