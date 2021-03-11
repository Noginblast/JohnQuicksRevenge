using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //can keep track of any amount of food it will be incremented in the OnTriggerEnter2d function- commented out for fututre use.
    //public int cherrires = 0;
    public CharacterController2D controller;
    public Animator animator;
    Rigidbody2D rb;
    AudioSource audsrc;

    public float runSpeed = 40f;
    float horizMove = 0f;
    bool isMoving;
    bool jump = false;
    bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audsrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(Mathf.Abs(rb.velocity.x) > 0.1)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }

        if(isMoving && !animator.GetBool("IsJumping"))
        {
            if(!audsrc.isPlaying)
                audsrc.Play();
        }
        else
        {
            audsrc.Stop();
        }

        animator.SetFloat("Speed", Mathf.Abs(horizMove));

        if (Input.GetButtonDown("Jump")){
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch")){
            crouch = true;
        } else if (Input.GetButtonUp("Crouch")){
            crouch = false;
        }
    }





    /*Caleb added this function: This is responsible for the collectables of the game.
      Basically if the tag = Collectable then we want to destroy it.*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Collectable")
        {
            Destroy(collision.gameObject);
            /*we may want to add this later if we want to keep track of the food
              we will want to uncomment this and the declaraction at the top to keep track of the amount of food*/
            //cherries += 1;
        }
    }


    public void OnLanding()
    {
        animator.SetBool("IsJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("IsCrouching", isCrouching);
    }

    void FixedUpdate() 
    {
        controller.Move(horizMove * Time.fixedDeltaTime,crouch,jump);
        jump = false;

    }
}
