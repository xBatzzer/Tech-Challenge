using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectManager : Employee
{
    public ProjectManager(EnumSeniority seniority) : base(seniority)
    {
        switch (seniority)
        {
            case EnumSeniority.Senior:
                baseSalary = 4000f;
                break;
            case EnumSeniority.SemiSenior:
                baseSalary = 2400f;
                break;
            case EnumSeniority.Junior:
                baseSalary = 0;
                break;
            default:
                break;
        }
    }

    public ProjectManager()
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
                salary += salary * 0.05f; 
                break;
            default:
                break;
        }

        return salary;
    }
}
