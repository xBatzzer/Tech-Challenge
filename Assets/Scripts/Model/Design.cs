using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Design : Employee
{
    public Design(EnumSeniority seniority) : base(seniority)
    {
        switch (seniority)
        {
            case EnumSeniority.Senior:
                baseSalary = 2000;
                break;
            case EnumSeniority.SemiSenior:
                baseSalary = 0;
                break;
            case EnumSeniority.Junior:
                baseSalary = 800;
                break;
            default:                
                break;
        }
    }

    public float Salary { get => salary; }
    public EnumSeniority Seniority { get => seniority; }

    public override float salaryIncrement()
    {
        salary = baseSalary;
        switch (seniority)
        {
            case EnumSeniority.Senior:
                salary += salary * 0.07f;
                break;
            case EnumSeniority.Junior:
                salary += salary * 0.04f;
                break;
            default:
                break;
        }

        return salary;
    }
}
