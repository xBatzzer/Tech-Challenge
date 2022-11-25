using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresenterSalary : IPresenterSalary
{
    IViewMain View;
    HumanResources hrSenior, hrSemiSenior, hrJunior;
    Design designSenior, designJunior;
    Engineering engineeringSenior, engineeringSemiSenior, engineeringJunior;
    Ceo ceo;
    Artist artistSenior, artistSemiSenior;
    ProjectManager pmSenior, pmSemiSenior;

    float incrementSalary;

    public PresenterSalary(IViewMain view)
    {
        hrSenior          = new HumanResources(EnumSeniority.Senior);
        hrSemiSenior      = new HumanResources(EnumSeniority.SemiSenior);
        hrJunior          = new HumanResources(EnumSeniority.Junior);

        designSenior      = new Design(EnumSeniority.Senior);
        designJunior      = new Design(EnumSeniority.Junior);

        engineeringSenior       = new Engineering(EnumSeniority.Senior);
        engineeringSemiSenior   = new Engineering(EnumSeniority.SemiSenior);
        engineeringJunior       = new Engineering(EnumSeniority.Junior);

        ceo         = new Ceo(EnumSeniority.Senior);

        artistSenior        = new Artist(EnumSeniority.Senior);
        artistSemiSenior    = new Artist(EnumSeniority.SemiSenior);

        pmSenior        = new ProjectManager(EnumSeniority.Senior);
        pmSemiSenior    = new ProjectManager(EnumSeniority.SemiSenior);

        View = view;
    }
     
    public void DeploySalaryHR()
    {
        incrementSalary = hrSenior.salaryIncrement();
        View.ShowInfo(hrSenior.Seniority, incrementSalary);
         
        incrementSalary = hrSemiSenior.salaryIncrement();
        View.ShowInfo(hrSemiSenior.Seniority, incrementSalary);

        incrementSalary = hrJunior.salaryIncrement();
        View.ShowInfo(hrJunior.Seniority, incrementSalary);
    }
    
    public void DeploySalaryDesign()
    {
        incrementSalary = designSenior.salaryIncrement();
        View.ShowInfo(designSenior.Seniority, incrementSalary);

        View.ShowInfo(EnumSeniority.SemiSenior, 0);

        incrementSalary = designJunior.salaryIncrement();
        View.ShowInfo(designJunior.Seniority, incrementSalary);
    }

    public void DeploySalaryEngineering()
    {
        incrementSalary = engineeringSenior.salaryIncrement();
        View.ShowInfo(engineeringSenior.Seniority, incrementSalary);

        incrementSalary = engineeringSemiSenior.salaryIncrement();
        View.ShowInfo(engineeringSemiSenior.Seniority, incrementSalary);

        incrementSalary = engineeringJunior.salaryIncrement();
        View.ShowInfo(engineeringJunior.Seniority, incrementSalary);
    } 
    public void DeploySalaryCeo()
    {
        incrementSalary = ceo.salaryIncrement();
        View.ShowInfo(ceo.Seniority, incrementSalary); 

    }
    public void DeploySalaryArtist()
    {
        incrementSalary = artistSenior.salaryIncrement();
        View.ShowInfo(artistSenior.Seniority, incrementSalary);

        incrementSalary = artistSemiSenior.salaryIncrement();
        View.ShowInfo(artistSemiSenior.Seniority, incrementSalary);

        View.ShowInfo(EnumSeniority.Junior, 0);
    }
    public void DeploySalaryPM()
    {
        incrementSalary = pmSenior.salaryIncrement(); 
        View.ShowInfo(pmSenior.Seniority, incrementSalary);

        incrementSalary = pmSemiSenior.salaryIncrement();
        View.ShowInfo(pmSemiSenior.Seniority, incrementSalary);

        View.ShowInfo(EnumSeniority.Junior, 0);
    }
}
