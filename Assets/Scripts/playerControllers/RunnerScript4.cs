using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerScript4 : MonoBehaviour
{
    private Rigidbody rbody;
    //private float runSpeed = 12.5f;
    private float runSpeed = 17f;
    private float originalSpeed;
    private float runMod = 0;
    //public int currentClass = 0;
    private float jumpSpeed = 8;
    private bool grounded = true;
    private bool walled = false;
    private float weight = 0;
    private float oldWeight=0;
    PersonalPlanning planning;

    void Start()
    {
        rbody = this.gameObject.GetComponent<Rigidbody>();
        planning = PersonalPlanning.instance;
        originalSpeed = runSpeed;
        weight = planning.GetWeightP1();
        oldWeight = weight;
        runSpeed -= weight * runSpeed;
    }

    // Update is called once per frame
    void Update()
    {

        if (weight != oldWeight)
        {
            runSpeed = originalSpeed -(weight * originalSpeed);
            oldWeight = weight;
        }

        if (!walled)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                runMod = 1f;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                runMod = -1f;
            }
            if (Input.GetKeyUp(KeyCode.L) || Input.GetKeyUp(KeyCode.J))
            {
                runMod = 0;
            }
        }

        rbody.velocity = new Vector3(runMod * runSpeed, rbody.velocity.y, 0);

        if (Input.GetKey(KeyCode.I) && grounded)
        {
            Debug.Log("jump");
            rbody.velocity = new Vector3(runSpeed, jumpSpeed, 0);
            grounded = false;
            //rbody.AddForce(new Vector3(50, jumpSpeed, 0));
        }
        if (!grounded)
        {
            Vector3 extraGravityForce = (Physics.gravity * 1.5f) - Physics.gravity;
            rbody.AddForce(extraGravityForce);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "terrain")
        {
            grounded = true;
        }

        if (collision.collider.tag == "MainCamera")
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

    public void UpdateSpeed()
    {
        weight = planning.GetWeightP1();
        runSpeed -= weight * runSpeed;
    }
}
