using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public SetDefaultCubes setDefault;
    public TargetManager targetManager;
    public Result resultManager;
    public ScoreManager scoreManager;
    private void OnMouseDown()
    {
        if (setDefault.IsCubesSelected())
        {
            GetComponent<RotateRandom>().Rotate();
            setDefault.ClearAllCubes();
            if (targetManager.targetValue>1)
            {
                targetManager.targetValue -= 1;
                scoreManager.DecreaseScore();
            }
            resultManager.value = 0;
        }
    }
}
