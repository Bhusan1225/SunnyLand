using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimmerLogic : MonoBehaviour
{

    public TextMeshProUGUI timmer;
    public float time =10.60f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            timmer.text = "time Remaining:" + time;
        }
        else if(time <= 0 && timmer.text != "GAME OVER")
        {
            timmer.text = "GAME OVER";

        }

    }
}
