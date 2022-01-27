using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerControllerEK : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    
    public float _dashTime = 0.1f;
    public float _dashSpeed = 10f;

    private void Update()
    {
        //Get move input
        //Preferably get input in Update()
        var moveInput = Input.GetAxis("Horizontal");

        //Set move velocity
        //Preferably interact with physics in FixedUpdate() 
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);

        //Get jump input
        //Preferably get input in Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //Apply jump force
        //Preferably interact with physics in FixedUpdate() 
        if (jumpInput)
            myRigidbody.AddForce(Vector3.up * jumpForce);
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(DashCoroutine());
        }
    }
    
    private IEnumerator DashCoroutine()
    {
        float startTime = Time.time; // need to remember this to know how long to dash
        while (Time.time < startTime + _dashTime)
        {
            if (Input.GetKey(KeyCode.D))
                transform.Translate(transform.right * _dashSpeed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A))
                transform.Translate(transform.right * -_dashSpeed * Time.deltaTime);
            // or controller.Move(...), dunno about that script
            yield return null; // this will make Unity stop here and continue next frame
        }
    }
}