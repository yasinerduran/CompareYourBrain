using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountSelectedCubes : MonoBehaviour
{
    [SerializeField] public List<Cube> cubes;
    
    public int SelectedCubeCount()
    {
        int counter = 0;
        foreach (var cube in cubes)
        {
            if (cube.isCubeSelected)
            {
                counter += 1;
            }
        }

        return counter;
    }
}
