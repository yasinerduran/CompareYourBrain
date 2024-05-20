using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public List<int> scores = new List<int>();

    public void IncreaseScore(int level, int cubeCount)
    {
        score += level * cubeCount;
        scores.Add(level * cubeCount);
    }

    public void DecreaseScore()
    {
        score -= scores[scores.Count-1];
        scores.RemoveAt(scores.Count-1);
    }
}
