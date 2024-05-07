using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operator : MonoBehaviour
{
    public ChangeColor color;
    public String operatorType;
    public bool isOperatorSelected = false;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == transform.name)
                {
                    if (!isOperatorSelected)
                    {
                        isOperatorSelected = true;
                        color.SetSelectedMaterial();
                    }
                    else
                    {
                        isOperatorSelected = false;
                        color.SetDefaultMaterial();
                    }
                }
            }
        }
    }
}