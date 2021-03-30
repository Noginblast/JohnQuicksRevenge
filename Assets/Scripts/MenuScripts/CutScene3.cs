using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene3 : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}