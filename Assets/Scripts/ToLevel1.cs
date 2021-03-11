using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel1 : MonoBehaviour
{
    public void PlayGame()
    {
        //changed this to load scene 1 because the other one wouldn't work with the end scene. But I left the code in case we want to come back to it.
        SceneManager.LoadScene(4);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}