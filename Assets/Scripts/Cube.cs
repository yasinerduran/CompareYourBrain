using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int activeNumber;
    private Rotate rotate;
    private ChangeColor color;
    public bool isCubeSelected = false;
    private OperatorManager operatorManager;
    
    
    // Start is called before the first frame update
    void Start()
    {
        color = this.GetComponent<ChangeColor>();
        rotate = this.GetComponent<Rotate>();
        operatorManager = FindObjectOfType<OperatorManager>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (operatorManager.isOperatorSelected)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.transform.name == transform.name)
                    {
                        if (!isCubeSelected)
                        {
                            isCubeSelected = true;
                            var result = FindObjectOfType<Result>();
                            result.Prosess(true,activeNumber);
                            color.SetSelectedMaterial();
                        }
                        else
                        {
                            /*
                            isCubeSelected = false;
                            var result = FindObjectOfType<Result>();
                            result.Prosess(false,activeNumber);
                            activeNumber = 0;
                            color.SetDefaultMaterial();
                            rotate.RandomRotate();*/
                        }
                    }
                }
            }
            else
            {
               
            }
        }
    }

    public void Clear()
    {
        isCubeSelected = false;
        activeNumber = 0;
        color.SetDefaultMaterial();
        rotate.RandomRotate();
    }
    
}
