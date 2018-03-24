using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerScript : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rbody;
    private float runSpeed = 15;
    private float runMod = 0;
    //public int currentClass = 0;
    private float jumpSpeed = 10;
    private bool grounded = true;
	void Start ()
    {
        rbody = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //rbody.AddForce(new Vector3(runSpeed, 0, 0));
        //float move = Input.GetAxis("Horizontal");
        //rbody.velocity = new Vector3(move * runSpeed, rbody.velocity.y, 0);
        if(Input.GetKeyDown(KeyCode.D))
        {
            runMod = 1f;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            runMod = -1f;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            runMod = 0;
        }

        rbody.velocity = new Vector3(runMod*runSpeed, rbody.velocity.y, 0);

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("jump");
            rbody.velocity = new Vector3(runSpeed*runMod, jumpSpeed, 0);
            grounded = false;
            //rbody.AddForce(new Vector3(50, jumpSpeed, 0));
        }
        if(!grounded)
        {
            Vector3 extraGravityForce = (Physics.gravity * 1.5f) - Physics.gravity;
            rbody.AddForce(extraGravityForce);
        }
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "terrain" )
        {
            grounded = true;
        }
    }
}
