using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour {

    int playerCount = 0;
    public float timeLim = 15;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(playerCount >=1)
        {
            timeLim -= Time.deltaTime;
        }

        if(playerCount <4 && timeLim <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

		if(playerCount == 4)
        {
            SceneManager.LoadScene(4);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag.Contains("Player"))
        {
            playerCount += 1;
        }
    }
}
