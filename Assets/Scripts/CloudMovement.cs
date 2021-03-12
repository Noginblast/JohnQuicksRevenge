using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{

    [SerializeField] private float CloudSpeed = 4;

    private Rigidbody2D rigidBodyComp;



    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComp = GetComponent<Rigidbody2D>();
        rigidBodyComp.velocity = new Vector2(CloudSpeed,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(rigidBodyComp.transform.position.x > 165){
            rigidBodyComp.transform.position = new Vector2(-57, rigidBodyComp.transform.position.y);
        }
    }
}
