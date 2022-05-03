using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ClockScript : MonoBehaviour
{
    public TMP_Text clock;
    int minutes;
    int seconds;
    public GameManager gm;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        // timeRemaining = 20f;    
        gm = GameObject.FindObjectOfType<GameManager>();
        timeRemaining = gm.timeForTimer;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown();
    }

    private void Countdown()
    {
        if(timeRemaining > 0) { 
            timeRemaining -= Time.deltaTime;
            minutes = Mathf.FloorToInt(timeRemaining / 60.0f);
            seconds = Mathf.RoundToInt(timeRemaining % 60.0f);
            if (seconds<10) {
                clock.text = minutes.ToString() + " : 0" + seconds.ToString();
            }
            else
            {
                clock.text = minutes.ToString() + " : " + seconds.ToString();
            }
        }
        else
        {
            timeRemaining = 0;
            clock.text = "0 : 00";
            TimeIsUp();

        }
    }

    private void TimeIsUp()
    {
        Debug.Log("Timer is finished");
    }
}
