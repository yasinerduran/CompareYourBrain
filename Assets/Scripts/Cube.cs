using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Number activeNumber;
    private Rotate rotate;
    private ChangeColor color;
    public bool isCubeSelected = false;
    
    // Start is called before the first frame update
    void Start()
    {
        color = this.GetComponent<ChangeColor>();
        rotate = this.GetComponent<Rotate>();
    }
    
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
                    if (!isCubeSelected)
                    {
                        isCubeSelected = true;
                        var result = FindObjectOfType<Result>();
                        result.value = result.value + activeNumber.value;
                        color.SetSelectedMaterial();
                    }
                    else
                    {
                        isCubeSelected = false;
                        var result = FindObjectOfType<Result>();
                        result.value = result.value - activeNumber.value;
                        color.SetDefaultMaterial();
                        rotate.RandomRotate();
                    }
                }
            }
        }
    }
}
