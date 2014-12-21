using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class TimeCycle : MonoBehaviour {

    const int MAX_DAYS = 25;
    const int START_DAY = 1;

    public float timeDelay = 1f;
    float nextIncrementTime;

    public float currentHours = 600f;
    public int daysLeft;
    public float hoursLeft;

    Text text;

	void Start () 
    {
        text = gameObject.GetComponent<Text>();
	}
	
	void Update () 
    {
        daysLeft = (int)currentHours / 24;
        hoursLeft = currentHours - daysLeft * 24;
        
        if (Time.time > nextIncrementTime) IncrementHour();

        text.text = ("Time Until\nChristmas\n" + daysLeft + ":" + ((hoursLeft < 10) ? "0" : "") +(int)hoursLeft);
	}

    void IncrementHour()
    {
        nextIncrementTime = Time.time + timeDelay;
        currentHours -= 0.5f;
    }
}
