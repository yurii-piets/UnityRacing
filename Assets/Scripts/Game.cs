using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject[] carPrefab;

    // Start is called before the first frame update
    void Start()
    {
//        Instantiate(carPrefab[PlayerSelection.selectedSceneId], mapSettings[PlayerSelection.selectedSceneId].start, Quaternion.identity);
        SceneManager.LoadScene(MapSettings.mapSettings[PlayerSelection.selectedSceneId].name, LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
