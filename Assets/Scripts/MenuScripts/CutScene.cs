﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    public void Continue(){
        SceneManager.LoadScene(4);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
