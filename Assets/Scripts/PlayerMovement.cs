using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

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
