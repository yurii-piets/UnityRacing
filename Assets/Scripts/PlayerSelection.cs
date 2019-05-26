using UnityEngine;
using UnityEngine.SceneManagement;

public static class PlayerSelection {

    public static Scene selectedScene
    {
        get { return selectedScene; }
        set { selectedScene = value; }
    }

    public static int selectedSceneId
    {
        get { return selectedSceneId; }
        set { selectedSceneId = value; }
    }
    
    public static GameObject selectedCar
    {
        get { return selectedCar; }
        set { selectedCar = value; }
    } 
    
    public static int selectedCarId
    {
        get { return selectedCarId; }
        set { selectedCarId = value; }
    } 
}
