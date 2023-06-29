using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scores : MonoBehaviour
{
    int score;
    public void ModifyScore(int value)
    {
        score += value;
        Mathf.Clamp(score, 0, int.MaxValue);
        
    }
    public int getScore()
    {
        return score;
    }
    public void resetScore()
    {
        score = 0;
    }
}
