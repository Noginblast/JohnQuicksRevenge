using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Newscene : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public int scoreRequirement;
    public DialogManager manager;
    public DialogTrigger Dtrigger;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(ScoreScript.scoreValue >= scoreRequirement)
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                Dtrigger.TriggerDialogue();
            }
        }
    }

}