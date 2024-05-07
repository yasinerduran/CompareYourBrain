using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource selectSound;
    public AudioSource unSelectSound;
    private ChangeColor color;
    // Start is called before the first frame update
    void Start()
    {
        color = this.GetComponent<ChangeColor>();
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
                    if (color.GetActiveMaterial()==color.defaultMaterial.color)
                    {
                       selectSound.Play();
                    }
                    else
                    {
                        unSelectSound.Play();
                    }
                }
            }
        }
    }
}