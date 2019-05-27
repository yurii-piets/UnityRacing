using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUpdate : MonoBehaviour
{
    public Text timeText;
    public Collider carCollider;
    public float seconds, minutes;
    public bool counterStarted = false;


    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>() as Text;
        carCollider = GetComponent<Collider>() as Collider;
    }

    // Update is called once per frame
    void Update()
    {
        if (counterStarted)
        {
            minutes = (int)(Time.time / 60f);
            seconds = (int)(Time.time % 60f);
            timeText.text = "Lap Time: " + minutes.ToString("00") + ":" + seconds.ToString("00");

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("startFinish"))
        {
            counterStarted = true;
        }
    }
}
