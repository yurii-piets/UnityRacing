using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{

    private string[] sceneNames = { "race_track_lake", "scene1-night", "sprint_track" };

    public GameObject[] carPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(sceneNames[PlayerSelection.selectedSceneId], LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
