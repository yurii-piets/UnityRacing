﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("TrackSelectionMenu");
    }

    public void Options() {

    }

    public void Quit() {
        Application.Quit();
    }
}
