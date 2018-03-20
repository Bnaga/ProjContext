﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoundTimer : MonoBehaviour {
    public float timeLim = 10;
    public float roundTime = 10;
    public RoundManager roundMan;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        CountDown();
	}

    void CountDown()
    {
        roundTime -= Time.deltaTime;
        if(roundMan.currentRound == 1 && roundTime <= 0)
        {
            roundMan.currentRound = 2;
            roundMan.roundChange = true;
            roundTime = timeLim;
        }
        if (roundMan.currentRound == 2 && roundTime <= 0)
        {
            roundMan.currentRound = 3;
            roundMan.roundChange = true;
            roundTime = timeLim;
        }
        if (roundMan.currentRound == 3 && roundTime <= 0)
        {
            roundMan.currentRound = 4;
            roundMan.roundChange = true;
            roundTime = timeLim;
        }
        if (roundMan.currentRound == 4 && roundTime <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}