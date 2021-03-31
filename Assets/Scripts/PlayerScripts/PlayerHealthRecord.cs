using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthRecord : MonoBehaviour
{
    private int health;
    TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
        health = PlayerHealth.health;
        score.text = "HEALTH: " + Mathf.Max(health,0);
    }
}
