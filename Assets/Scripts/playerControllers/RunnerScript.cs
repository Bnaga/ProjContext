using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerScript : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rbody;
    //private float runSpeed = 12.5f;
    private float runSpeed = 17;
    private float originalSpeed;
    private float runMod = 0;
    //public int currentClass = 0;
    private float jumpSpeed = 8;
    private bool grounded = true;
    private bool walled = false;
    private float weight = 0;
    private float oldWeight = 0;

    PersonalPlanning planning;

    void Start ()
    {
        planning = PersonalPlanning.instance;
        rbody = this.gameObject.GetComponent<Rigidbody>();
        originalSpeed = runSpeed;
        weight = planning.GetWeightP1();
        oldWeight = weight;
        runSpeed -= weight * runSpeed;
    }
	
	// Update is called once per frame
	void Update ()
    {
        weight = planning.GetWeightP1();
        Debug.Log(weight);
        Debug.Log(runSpeed);
        if(weight != oldWeight)
        {
            runSpeed = originalSpeed - (weight * originalSpeed);
            oldWeight = weight;
        }
        //weight = planning.GetWeightP1();
        if (!walled)
        {
            if (Input.GetKeyDown(KeyCode.D))
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
        }

        rbody.velocity = new Vector3(runMod*runSpeed, rbody.velocity.y, 0);

        if (Input.GetKey(KeyCode.W) && grounded)
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

        if(collision.collider.tag == "MainCamera")
        {
            walled = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "MainCamera")
        {
            walled = false;
        }
    }
}
