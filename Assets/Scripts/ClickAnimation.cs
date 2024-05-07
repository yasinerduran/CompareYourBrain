using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
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
                    animator.SetBool("Click",true);
                    StartCoroutine(DelayedFunction(0.5f));
                }
            }
        }
    }
    
    IEnumerator DelayedFunction(float delayTime)
    {
        // Belirlenen süre kadar bekler
        yield return new WaitForSeconds(delayTime);

        // Süre sonunda çalışacak fonksiyon
        FunctionToRun();
    }

    void FunctionToRun()
    {
        animator.SetBool("Click",false);
    }
    
    
}
