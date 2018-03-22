using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    // Use this for initialization
    private void Start()
    {
        Destroy(GameObject.FindGameObjectWithTag("gameman"));
        Destroy(GameObject.Find("GameManager"));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
