using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelection : MonoBehaviour
{
    public void SelectMap(int mapId)
    {
        PlayerSelection.selectedSceneId = mapId;
        SceneManager.LoadScene("CarSelectionMenu");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Start()
    {
           
    }

    public void Update()
    {
        
    }
}