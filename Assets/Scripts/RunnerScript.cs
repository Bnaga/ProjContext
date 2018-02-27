using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerScript : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rbody;
    private float runSpeed = 7;
    public int currentClass = 0;
    public float jumpSpeed = 45;
	void Start ()
    {
        rbody = this.gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //rbody.AddForce(new Vector3(runSpeed, 0, 0));
        rbody.velocity = new Vector3(runSpeed, 0, 0);
        if (currentClass == 1)
        {
            runSpeed = 5;
        }

        if (Input.GetButton("Jump"))
        {
            Debug.Log("jump");
            rbody.velocity = new Vector3(runSpeed, jumpSpeed, 0);
            //rbody.AddForce(new Vector3(50, jumpSpeed, 0));
        }

    }
}
