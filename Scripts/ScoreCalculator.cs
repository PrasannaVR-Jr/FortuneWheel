using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculator : MonoBehaviour
{
    public int CalculateScore(Transform Wheel)
    {
        int score;
        float localRotation = Wheel.localEulerAngles.z;
        Debug.Log(localRotation+"\n"+ Mathf.FloorToInt(localRotation / (360 / 7)));
        
        score = Mathf.FloorToInt(localRotation / (360 / 7));

        if (score == 0)
        {
            score = 7;
        }

        return score;

        
        
    }
}
