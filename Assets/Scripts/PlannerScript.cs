using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlannerScript : MonoBehaviour {

    int currentRound = 1;
    int hoverTask = 0;
    GameObject[] task;
    // Use this for initialization

    private void Awake()
    {
        task = GameObject.FindGameObjectsWithTag("task1");
        this.gameObject.transform.position = task[hoverTask].transform.position;
    }
    void Start ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        //task = GameObject.FindGameObjectsWithTag("task1");
        //this.gameObject.transform.position = task[hoverTask].transform.position;

    }

    private void Update()
    {

        
        if (currentRound == 1)
        {
            
            if (Input.GetKey("d"))
            {
                /*
                if(hoverTask == 0)
                {
                    hoverTask = 1;
                }
                if (hoverTask == 1)
                {
                    hoverTask = 2;
                }
                if (hoverTask == 2)
                {
                    hoverTask = 3;
                }
                if (hoverTask == 3)
                {
                    hoverTask = 4;
                }
                */
                hoverTask++;
                this.gameObject.transform.position = task[hoverTask].transform.position;

            }
            if (Input.GetKey("a"))
            {
                hoverTask--;
                this.gameObject.transform.position = task[hoverTask].transform.position;

            }
        }
    }
}
