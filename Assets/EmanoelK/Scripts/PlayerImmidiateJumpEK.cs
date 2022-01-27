using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmidiateJumpEK : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float jumpForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get jump input
        //Preferably get input in Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //Apply jump force
        //Preferably interact with physics in FixedUpdate() 
        if (jumpInput)
            myRigidbody.AddForce(Vector3.up * jumpForce);
    }
}
