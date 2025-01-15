using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    float score;
    public TextMeshProUGUI Score_text;
 
    public void InceaseScore(float Increment)
    {
        score += Increment;
        Score_text.text = "Score:" + score;
    }
}
