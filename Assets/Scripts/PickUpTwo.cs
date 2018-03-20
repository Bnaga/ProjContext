using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTwo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "green" || collision.collider.tag == "yellow" || collision.collider.tag == "blue" || collision.collider.tag == "pink")
        {
            Destroy(collision.collider.gameObject);
        }
    }
}
