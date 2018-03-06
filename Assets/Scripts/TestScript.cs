using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

    public RunnerScript runscpt;
	// Use this for initialization
	void Start () {
        runscpt = this.gameObject.GetComponent<RunnerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "class1")
        {
            //runscpt.currentClass = 1;
        }
    }
}
