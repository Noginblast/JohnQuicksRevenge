using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        score = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Food: " + scoreValue ;
    }
}
