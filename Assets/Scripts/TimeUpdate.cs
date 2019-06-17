using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUpdate : MonoBehaviour
{
    public Text timeText;
    public float millis, seconds, minutes;
    public bool timeStarted;
    private float startTime;


    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>() as Text;
        startTime = Time.time;
        timeStarted = true;
        //timeStarted = false;

    }

    // Update is called once per frame
    void Update()
    {
    	if(timeStarted) {
    		float t = Time.time - startTime;

            minutes = (int)(t / 60f);
            seconds = (int)(t % 60f);
            millis = (int)(t * 1000f);
            timeText.text = "Lap Time: " + minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + (millis%1000).ToString("000"); 
		}
    }

    void resetTime() {
    	startTime = Time.time;
    }

}
