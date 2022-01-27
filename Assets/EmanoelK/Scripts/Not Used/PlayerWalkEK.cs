using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkEK : MonoBehaviour
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
