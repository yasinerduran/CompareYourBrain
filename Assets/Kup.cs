using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kup : MonoBehaviour
{
    
    public int hacim = 10;

    private void OnMouseDown()
    {
        var silindir = FindObjectsOfType<Silindir>();
        Debug.Log(silindir.Length);
    }
}
