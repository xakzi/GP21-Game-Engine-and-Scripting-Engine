using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerControllerEK : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;

    private void Update()
    {
        //Get move input
        //Preferably get input in Update()
        var moveInput = Input.GetAxis("Horizontal");

        //Set move velocity
        //Preferably interact with physics in FixedUpdate() 
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);

     
    }
}