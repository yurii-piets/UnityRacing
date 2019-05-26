using UnityEngine;
using UnityEngine.SceneManagement;

public static class PlayerSelection {

    private static Scene selectedScene
    {
        get { return selectedScene; }
        set { selectedScene = value; }
    }

    private static int selectedSceneId
    {
        get { return selectedSceneId; }
        set { selectedSceneId = value; }
    }
    
    private static GameObject selectedCar
    {
        get { return selectedCar; }
        set { selectedCar = value; }
    } 
    
    private static int selectedCarId
    {
        get { return selectedCarId; }
        set { selectedCarId = value; }
    } 
}
