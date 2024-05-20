using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Result : MonoBehaviour
{
    public int value;

    private OperatorManager operatorManager;
    private void Start()
    {
        operatorManager = FindObjectOfType<OperatorManager>();
    }

    public void Multiple(int val)
    {
        value = value * val;
    }
    
    public void Div(int val)
    {
        value = value / val;
    }
    
    public void Sum(int val)
    {
        value = value + val;
    }
    
    public void Extract(int val)
    {
        value = value - val;
    }

    public void Prosess(bool select ,int val)
    {
       
        
        if (operatorManager.selectedOperator.operatorType == "Sum")
        {
            if (select)
            {
                Sum(val);
            }
            else
            {
                Extract(val);
            }
        }
        
        if (operatorManager.selectedOperator.operatorType == "Extract")
        {
            if (select)
            {
                Extract(val);
            }
            else
            {
                Sum(val);
            }
        }

        
        if (operatorManager.selectedOperator.operatorType == "Multiple")
        {
            if (select)
            {
                Multiple(val);
            }
            else
            {
                Div(val);
            }
        }
    }
    
}
