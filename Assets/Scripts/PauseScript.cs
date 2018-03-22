using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public bool isPaused = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else Time.timeScale = 1;
		
	}
}
