using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefaultCubes : MonoBehaviour
{
    [SerializeField] public List<Cube> cubes;
    // Start is called before the first frame update

    public void ClearAllCubes()
    {
        foreach (var cube in cubes)
        {
            if (cube.isCubeSelected)
            {
                cube.Clear();
            }
        }
    }


    public bool IsCubesSelected()
    {
        foreach (var cube in cubes)
        {
            if (cube.isCubeSelected)
            {
                return true;
            }
        }

        return false;
    }
}
