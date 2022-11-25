using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanResources : Employee
{    
    public HumanResources(EnumSeniority seniority) : base(seniority) 
    {
        switch (seniority)
        {
            case EnumSeniority.Senior:
                baseSalary = 1500f;
                break;
            case EnumSeniority.SemiSenior:
                baseSalary = 1000f;
                break;
            case EnumSeniority.Junior:
                baseSalary = 500f;
                break;
            default: 
                break;
        }
    }

    public HumanResources()
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
                salary += salary * 0.05f;
                break;
            case EnumSeniority.SemiSenior:
                salary += salary * 0.02f;
                break;
            case EnumSeniority.Junior:
                salary += salary * 0.005f;
                break;
            default:
                break;
        }

        return salary;
    }
}
