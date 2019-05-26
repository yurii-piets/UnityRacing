using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSelection : MonoBehaviour
{
    public void SelectMap(int mapId)
    {
        PlayerSelection.selectedSceneId = mapId;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Start()
    {
           
    }

    public void Update()
    {
        
    }
}