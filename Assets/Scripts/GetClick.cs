using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GetClick : MonoBehaviour
{
    public Cube cube;
    private void OnMouseDown()
    {
        var number = GetComponent<GetCard>();
        cube.activeNumber = number.number;
    }
}
