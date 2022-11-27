using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator animator;
    public float forwardSpeed;
    public float rightSpeed;
    // Start is called before the first frame update
    void Start()
    {
        CharacterIni();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAnimParams();
        JumpCheck();
    }

    void CharacterIni() 
    {
        //get the animtor component on character
        animator = GetComponent<Animator>();
    }

    

    //update parameters in animator according to players inputs
    void UpdateAnimParams() 
    {

        //set floats used in animator accordind to inputs
        if (Input.GetKey(KeyCode.W))
        {
            if (forwardSpeed <= 1f) 
            {
                forwardSpeed += 10f * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (forwardSpeed >= -1f)
            {
                forwardSpeed -= 10f * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (rightSpeed >= -1f) 
            {
                rightSpeed -= 10f * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (rightSpeed <= 1f)
            {
                rightSpeed += 10f * Time.deltaTime;
            }
        }

        //if no keys is pressed, reset the floats
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)) 
        {
            forwardSpeed = Mathf.Lerp(forwardSpeed,0f,0.1f);
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)) 
        {
            rightSpeed = Mathf.Lerp(rightSpeed,0f,0.1f);
        }

        //update the parameters in animator
        animator.SetFloat("RightSpeed", rightSpeed);
        animator.SetFloat("ForwardSpeed", forwardSpeed);

    }


    //set trigger to change animation state
    void JumpCheck() 
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            animator.SetTrigger("Jump");
        }
        
    }

   
}
