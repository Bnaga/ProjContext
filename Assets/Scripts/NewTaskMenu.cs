using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTaskMenu : MonoBehaviour {

    public bool p1Paused = false;
    public bool p2Paused = false;
    public bool p3Paused = false;
    public bool p4Paused = false;
    public GameObject p1Menu;
    public GameObject p2Menu;
    public GameObject p3Menu;
    public GameObject p4Menu;

    public GameObject player;

    public Rigidbody task;
    private float xShot = 1.5f;
    private float throwSpeed = 15;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
