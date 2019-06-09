﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{

    private const int SCALE = 90;
    [Header("Select amount of your objects")]
    [Range(1, 100)]
    public int amount;
    [Header("Select smooth speed")]
    [Range(0.05f, 5.0f)]
    public float smoothSpeed;

    [Header("Select distance between objects")]
    [Range(5, 20)]
    public int distance;

    [Header("Select names for your objects")]
    public string[] names;
	public GameObject[] obj;
    private GameObject[] instatiatedObj;
    private Vector2[] points;
    public GameObject parentScroll;
    public Text characterName;
    private float smoothedX, smoothedScale;
    private Vector3[] defaultScale, bigScale;
    
    void Start()
    {
        instatiatedObj = new GameObject[amount];
        points = new Vector2[amount + 1];
        defaultScale = new Vector3[amount];
        bigScale = new Vector3[amount];
        for(int i = 0; i < amount; i++)
        { 
            if(i == 0) instatiatedObj[i] = Instantiate(obj[i], new Vector3(0, parentScroll.transform.position.y, 70), Quaternion.identity);
            if(i != 0) instatiatedObj[i] = Instantiate(obj[i], new Vector3(instatiatedObj[i-1].transform.position.x + distance,
                    instatiatedObj[i-1].transform.position.y, instatiatedObj[i-1].transform.position.z), Quaternion.identity);
            instatiatedObj[i].transform.parent = parentScroll.transform;
            instatiatedObj[i].transform.Rotate(-10, 0, 0);
            defaultScale[i] = new Vector3(instatiatedObj[i].transform.localScale.x - 25, instatiatedObj[i].transform.localScale.y, instatiatedObj[i].transform.localScale.z);
            bigScale[i] = new Vector3(instatiatedObj[i].transform.localScale.x + SCALE, instatiatedObj[i].transform.localScale.y + SCALE, instatiatedObj[i].transform.localScale.z + SCALE);
        }
        for(int y = 0; y < amount + 1; y++)
        {
            if(y == 0) points[y] = new Vector2(parentScroll.transform.position.x + distance / 2, parentScroll.transform.position.y);
            if(y != 0) points[y] = new Vector2(points[y-1].x - distance, parentScroll.transform.position.y);
        }
        
    }

    void Update()
    {
        try
        {
            for(int i = 0; i < amount; i++)
            {
               instatiatedObj[i].transform.Rotate(0, 1, 0); 
               if(parentScroll.transform.position.x < points[i].x && parentScroll.transform.position.x > points[i+1].x)
               {
                   smoothedX = Mathf.SmoothStep(parentScroll.transform.position.x, points[i].x - distance / 2, smoothSpeed);
                   smoothedScale = Mathf.SmoothStep(bigScale[i].x, defaultScale[i].x, smoothSpeed);
                   characterName.text = names[i];
               }
               else smoothedScale = Mathf.SmoothStep(defaultScale[i].x, bigScale[i].x, smoothSpeed);
               instatiatedObj[i].transform.localScale = new Vector3(smoothedScale, smoothedScale, smoothedScale);
            }
        }
        catch
        {
        }
        parentScroll.transform.position = new Vector2(smoothedX, parentScroll.transform.position.y);
    }
    public void ButtonClick()
    {
        if (EventSystem.current.currentSelectedGameObject.name == "Back")
        {
            SceneManager.LoadScene("TrackSelectionMenu");
        }
        else
        {
            PlayerSelection.selectedCarId = GetSelectedCarId();
            SceneManager.LoadScene("GameScene");
        }
    }

    private int GetSelectedCarId()
    {
        for (int i = 0; i < amount; i++)
        {
            if (parentScroll.transform.position.x < points[i].x && parentScroll.transform.position.x > points[i + 1].x)
            {
                return i;
            }
        }
        return 2;
    }
}
