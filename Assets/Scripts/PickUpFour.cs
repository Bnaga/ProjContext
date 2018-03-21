using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (PersonalPlanning.instance.tasksP3.Count < 5)
        {
            if (other.tag == "green" || other.tag == "yellow" || other.tag == "blue" || other.tag == "pink")
            {
                Destroy(other.gameObject);
            }
        }
    }
}
