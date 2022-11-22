using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 2f;
    Animator animator;
    public float forwardSpeed;
    public float rightSpeed;
    // Start is called before the first frame update
    void Start()
    {
        CharacterIni();
    }

    // using different func to control the anim
    void Update()
    {
        MovementControl();
        //AnimTransitControl();
        //AnimBlendControl();
    }

    void CharacterIni() 
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void MovementControl() 
    {
        //set up a new vector3 to store the pos  
        Vector3 newPos = transform.position;

        //update the vector3 to store the pos change
        if (Input.GetKey(KeyCode.W)) 
        {
            newPos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += speed * Time.deltaTime;
        }


        //update character pos using the vector3
        transform.position = newPos;
    }


    //change transition parameters to change animations
    void AnimTransitControl() 
    {

    }


    //change blend patameters to blend animations
    void AnimBlendControl() 
    {

    }

    

}
