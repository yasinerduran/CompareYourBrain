using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Number", menuName = "MyObjects/Numbers")]
public class Number : ScriptableObject
{
    public Sprite image;
    public Sprite imageContrast;
    public string name;
    public int value;
}
