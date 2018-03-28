using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

    bool p1 = true;
    bool p2 = true;
    bool p3 = true;
    bool p4 = true;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if(GameObject.FindGameObjectWithTag("Player1") == null)
        {
            p1 = false;
        }
        if (GameObject.FindGameObjectWithTag("Player2") == null)
        {
            p2 = false;
        }
        if (GameObject.FindGameObjectWithTag("Player3") == null)
        {
            p3 = false;
        }
        if (GameObject.FindGameObjectWithTag("Player4") == null)
        {
            p4 = false;
        }

        if(Input.GetKeyDown(KeyCode.F12))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


        if (!p1 && !p2 && !p3 && !p4)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        
    }
}
