using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artist : Employee
{
    public Artist(EnumSeniority seniority) : base(seniority) 
    {
        switch (seniority)
        {
            case EnumSeniority.Senior:
                baseSalary = 2000; 
                break;
            case EnumSeniority.SemiSenior:
                baseSalary = 1200;
                break;
            case EnumSeniority.Junior:
                baseSalary = 0;
                break;
            default:                
                break;
        } 
    }

    public Artist()
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
                salary += (salary * 0.025f);
                break;
            default:
                break;
        }

        return salary;
    }
}
