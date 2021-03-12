using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    private bool startButtonOn;

    private bool pauseRan;
    private bool resumeRan;
    public GameObject startButton;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        startButtonOn = startButton.activeSelf;
        if(startButtonOn){
            Pause();
            pauseRan = true;
        }
        else{
            Resume();
            resumeRan = true;
        }
    }

    void Pause(){
        if(!pauseRan){
            PauseMenu.Pause2();
            resumeRan = false;
        }
    }

    void Resume(){
        if(!resumeRan){
            PauseMenu.Resume2();
            pauseRan = false;
        }
    }
}
