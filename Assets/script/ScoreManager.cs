using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    float score;
    public TextMeshProUGUI Score_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InceaseScore(float Increment)
    {
        score += Increment;
        Score_text.text = "Score:" + score;
    }
}
