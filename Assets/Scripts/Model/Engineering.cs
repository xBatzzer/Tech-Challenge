using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engineering : Employee
{
    public Engineering(EnumSeniority seniority) : base(seniority) 
    {
        switch (seniority)
        {
            case EnumSeniority.Senior:
                baseSalary = 5000;
                break;
            case EnumSeniority.SemiSenior:
                baseSalary = 3000;
                break;
            case EnumSeniority.Junior:
                baseSalary = 1500;
                break;
            default:
                break;
        }
    }

    public Engineering()
    {

    }

    public float Salary { get => salary; }
    public EnumSeniority Seniority { get => seniority; }

    public override float salaryIncrement()
    {
        salary = baseSalary;
        switch (seniority)
        {
            case EnumSeniority.Senior:
                salary += salary * 0.1f;
                break;
            case EnumSeniority.SemiSenior:
                salary += salary * 0.07f;
                break;
            case EnumSeniority.Junior:
                salary += salary * 0.05f;
                break;
            default:
                break;
        }

        return salary;
    }
}
