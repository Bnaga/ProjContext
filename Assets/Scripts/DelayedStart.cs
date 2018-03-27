using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedStart : MonoBehaviour {
    public GameObject CountDown;
	// Use this for initialization
	void Start () {
        StartCoroutine("StartDelay");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator StartDelay()
    {
        Time.timeScale = 0;
        float PauseTime = Time.realtimeSinceStartup + 3f;
        while (Time.realtimeSinceStartup < PauseTime)
            yield return 0;
        CountDown.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    

}
