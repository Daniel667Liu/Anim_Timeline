using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 2f;
    public float JumpStrength = 30f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // using different func to control the anim
    void Update()
    {
        MovementControl();
      
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


    //add force to jump, should be called in animation
    public void AddJumpForce() 
    {
        rb.AddForce(Vector3.up * JumpStrength, ForceMode.Force);
    }


}
