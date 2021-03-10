using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReset : MonoBehaviour
{
    public float waitPeriod = 3;
    private int playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth = PlayerHealth.health;

        if (playerHealth <= 0)
        {
            StartCoroutine(Restart(waitPeriod));
        }
    }

    public IEnumerator Restart(float f)
     {
         yield return new WaitForSeconds(f);
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     }
}
