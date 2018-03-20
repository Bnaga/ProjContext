﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class P1Menu : MonoBehaviour {

    PersonalPlanning planning;
    TaskSpot[] spotsP1;

    public bool p1Paused = false;
    public GameObject p1Menu;
    public GameObject player;
    public GameObject player1;

    public Rigidbody task;
    private float xShot = 1.5f;
    private float throwSpeed = 15;

    public Button task1;
    //public GameObject taskObj1;
    public Button task2;
    //public GameObject taskObj2;
    public Button task3;
    //public GameObject taskObj3;
    public Button task4;
    //public GameObject taskObj4;
    public Button task5;
    //public GameObject taskObj5;
    // Use this for initialization
    void Start ()
    {
        planning = PersonalPlanning.instance;
        player = GameObject.FindGameObjectWithTag("Player1");
        spotsP1 = player1.GetComponentsInChildren<TaskSpot>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        UpdateUI1();
        if (p1Paused)
        {
            p1Menu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            p1Menu.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            p1Paused = !p1Paused;
        }
    }

    public void ThrowTask1()
    {
        Rigidbody taskThrow = Instantiate(task, new Vector3(player.transform.position.x + xShot, player.transform.position.y, player.transform.position.z), Quaternion.identity) as Rigidbody;
        //taskThrow.AddForce(player.transform.right * throwSpeed);
        taskThrow.velocity = (new Vector3(throwSpeed, 6.5f, 0));
        //throwSpeed *= 0.8f;
        p1Paused = !p1Paused;
        
    }

    public void ShowList()
    {

    }

    void UpdateUI1()
    {
        Debug.Log("updating UI1");

        for (int i = 0; i < spotsP1.Length; i++)
        {
            if (i < planning.tasksP1.Count)
            {
                spotsP1[i].AddTask(planning.tasksP1[i]);
            }
            else
            {
                spotsP1[i].ClearSpot();
            }
        }
    }
}