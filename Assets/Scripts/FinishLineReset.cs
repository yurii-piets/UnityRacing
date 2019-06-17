using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineReset : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other) {
    	GameObject.Find("TimeText").SendMessage("setTimerFalse");
    }
    private void OnTriggerExit(Collider other) {
    	GameObject.Find("TimeText").SendMessage("resetTime");
    	GameObject.Find("TimeText").SendMessage("setTimerTrue");
    }
    private void OnTriggerEnter(Collider other) {
    	GameObject.Find("TimeText").SendMessage("resetTime");
    }
}
