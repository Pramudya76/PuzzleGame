using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    private float time = 180f;
    public TextMeshProUGUI TextTimer;
    public GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        int timerInt = Mathf.CeilToInt(time);
        TextTimer.text = timerInt.ToString();
        if(time <= 60 && time > 30) {
            TextTimer.color = Color.yellow;
        }else if(time <= 30 && time > 0) {
            TextTimer.color = Color.red;
        }else if(time <= 0) {
            TextTimer.text = "0";
            GameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }
}
