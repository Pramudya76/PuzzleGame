using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    private float time = 180f;
    public TextMeshProUGUI TextTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        int timerInt = Mathf.CeilToInt(time);
        TextTimer.text = timerInt.ToString();
        if(time <= 60 && time > 30) {
            TextTimer.color = Color.yellow;
        }else if(time <= 30) {
            TextTimer.color = Color.red;
        }else if(time <= 0) {
            TextTimer.text = "0";
        }
    }
}
