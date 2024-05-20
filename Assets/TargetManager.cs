using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public int targetValue;
    public AudioSource levelUP;
    private Result resultManager;
    private ScoreManager scoreManager;
    
    // Start is called before the first frame update
    void Start()
    {
        resultManager = FindObjectOfType<Result>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (resultManager.value==targetValue)
        {
            var selectedCubeCount = FindObjectOfType<CountSelectedCubes>().SelectedCubeCount();
            scoreManager.IncreaseScore(targetValue,selectedCubeCount);
            
            levelUP.Play();
            targetValue += 1;
            resultManager.value = 0;
            
            GetComponent<SetDefaultCubes>().ClearAllCubes();

        }
    }
}
