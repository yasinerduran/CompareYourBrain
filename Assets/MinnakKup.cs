using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinnakKup : MonoBehaviour
{
    public GameObject babaküp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(babaküp.GetComponent<Hareket>().hiz);
    }
}
