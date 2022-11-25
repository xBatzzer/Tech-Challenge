using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewMain : MonoBehaviour, IViewMain
{
    [SerializeField] private Text juniorText, semiSeniorText, seniorText, ceoText;

    IPresenterSalary presenter;
    bool isCeo;

    public void Start()
    {
        presenter = new PresenterSalary(this);
    }

    public void User_Event_HR()
    {
        isCeo = false;
        presenter.DeploySalaryHR();
    }

    public void User_Event_PM()
    {
        isCeo = false;
        presenter.DeploySalaryPM();
    }

    public void User_Event_CEO() 
    {
        isCeo = true;
        presenter.DeploySalaryCeo();
    }

    public void User_Event_Designer()
    {
        isCeo = false; 
        presenter.DeploySalaryDesign();
    }

    public void User_Event_Engineering()
    {
        isCeo = false;
        presenter.DeploySalaryEngineering();
    }

    public void User_Event_Artist()
    {
        isCeo = false;
        presenter.DeploySalaryArtist();
    }

    public void ShowInfo(EnumSeniority seniority, float salary)
    {         
        if (isCeo)
        {
            ceoText.text = salary.ToString();
        }
        else
        {
            switch (seniority)
            {
                case EnumSeniority.Senior:
                    seniorText.text = salary.ToString();
                    break;
                case EnumSeniority.SemiSenior:
                    semiSeniorText.text = salary.ToString();
                    break;
                case EnumSeniority.Junior:
                    juniorText.text = salary.ToString();
                    break;
                default:
                    break;
            }
        }

    }
}
