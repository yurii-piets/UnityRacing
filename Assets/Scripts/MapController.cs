using UnityEngine;

public class MapController : MonoBehaviour
{
    
    public GameObject[] carPrefabs;
    
    public void Start()
    {
        Instantiate(carPrefabs[PlayerSelection.selectedCarId], MapSettings.mapSettings[PlayerSelection.selectedSceneId].start, MapSettings.mapSettings[PlayerSelection.selectedSceneId].rotation);
    }
}