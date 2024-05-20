using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OperatorManager : MonoBehaviour
{
    public bool isOperatorSelected;

    public Operator selectedOperator;

    public List<Operator> operatorList;

    // Start is called before the first frame update
    void Start()
    {
        selectedOperator = null;
    }

    public void Update()
    {
        ClickEventForOperator();
    }

    public void ClickEventForOperator()
    {
        
        bool flag = false;
       
        for (int i = 0; i < operatorList.Count; i++)
        {
            if (selectedOperator != operatorList[i])
            {
                operatorList[i].color.SetDefaultMaterial();
                operatorList[i].isOperatorSelected = false;
            }

            if (operatorList[i].isOperatorSelected)
            {
                flag = true;
                isOperatorSelected = true;
            }
        }

        if (!flag)
        {
            isOperatorSelected = false;
            selectedOperator = null;
        }
    }
}
