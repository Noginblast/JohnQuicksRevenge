using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolf : MonoBehaviour
{
    private float leftCap;
    private float rightCap;
    [SerializeField] private float range = 10;

    [SerializeField] private float speed = 10f;
    [SerializeField] private LayerMask ground;

    private Collider2D coll;
    private Rigidbody2D rb;
    private float[] scale = new float[2];



    private bool facingLeft = false;

    private void Start(){
        coll = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
        scale[0] = transform.localScale.x;
        scale[1] = transform.localScale.y;
        leftCap = transform.position.x - range/2;
        rightCap = transform.position.x + range/2;

    }

    // Update is called once per frame
    void Update()
    {
        if(facingLeft){
            if(transform.position.x > leftCap){
                if(transform.localScale.x != scale[0]){
                    transform.localScale = new Vector3(scale[0],scale[1]);
                    rb.velocity = new Vector2(-speed,0);
                }
            }
            else{
                facingLeft = false;
            }
        }
        else{
            if(transform.position.x < rightCap){
                if(transform.localScale.x != -scale[0]){
                    transform.localScale = new Vector3(-scale[0],scale[1]);
                    rb.velocity = new Vector2(speed,0);
                }
            }
            else{
                facingLeft = true;
            }
        }
    }
}
