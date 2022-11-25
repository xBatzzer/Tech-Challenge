using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee
{        
    protected EnumSeniority seniority;
    protected float salary, baseSalary;

    public Employee(EnumSeniority seniority) 
    {
        this.seniority = seniority;
        //this.baseSalary = baseSalary;
    }

    public Employee()
    {

    }

    public virtual float salaryIncrement()
    {
        return salary;
    }
}
