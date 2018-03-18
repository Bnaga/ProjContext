using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlannerScript : MonoBehaviour {

    int currentRound = 0;
    public RoundManager roundMan;
    //int hoverTask = 0;
    // Use this for initialization

    private void Awake()
    {
    }
    void Start ()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        //task = GameObject.FindGameObjectsWithTag("task1");
        //this.gameObject.transform.position = task[hoverTask].transform.position;
        

    }

    private void Update()
    {
        currentRound = roundMan.currentRound;

        #region Player1

        if (Input.GetKeyUp("a"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("green"); ;
            if (currentRound == 1)
            {
                task = GameObject.FindGameObjectWithTag("green");
            }
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("green2");
            }

            if (PersonalPlanning.instance.LenP1() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask1();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKey("w"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("yellow");
            
                if (PersonalPlanning.instance.LenP1() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask1();
                }
                else Debug.Log("already picked a task");
            
        }


        if (Input.GetKey("d"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("pink");

                if (PersonalPlanning.instance.LenP1() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask1();
                }
                else Debug.Log("already picked a task");

        }
        #endregion

        #region Player2

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            GameObject task = GameObject.FindGameObjectWithTag("green");
            if (currentRound == 1)
            {
                task = GameObject.FindGameObjectWithTag("green");
            }
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("green2");
            }

            if (PersonalPlanning.instance.LenP2() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask2();
                }
                else Debug.Log("already picked a task");
            
        }


        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            GameObject task = GameObject.FindGameObjectWithTag("yellow");

                if (PersonalPlanning.instance.LenP2() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask2();
                }
                else Debug.Log("already picked a task");

        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GameObject task = GameObject.FindGameObjectWithTag("pink");

                if (PersonalPlanning.instance.LenP2() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask2();
                }
                else Debug.Log("already picked a task");
            
        }
        #endregion

        #region Player3

        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            GameObject task = GameObject.FindGameObjectWithTag("green");
            if (currentRound == 1)
            {
                task = GameObject.FindGameObjectWithTag("green");
            }
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("green2");
            }

            if (PersonalPlanning.instance.LenP3() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask3();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            GameObject task = GameObject.FindGameObjectWithTag("yellow");

                if (PersonalPlanning.instance.LenP3() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask3();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            GameObject task = GameObject.FindGameObjectWithTag("pink");

                if (PersonalPlanning.instance.LenP3() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask3();
                }
                else Debug.Log("already picked a task");
            
        }
        #endregion

        #region Player4

        if (Input.GetKeyUp("j"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("green");
            if (currentRound == 1)
            {
                task = GameObject.FindGameObjectWithTag("green");
            }
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("green2");
            }

            if (PersonalPlanning.instance.LenP4() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask4();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKey("i"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("yellow");

                if (PersonalPlanning.instance.LenP4() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask4();
                }
                else Debug.Log("already picked a task");
            
        }


        if (Input.GetKey("l"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("pink");
 
                if (PersonalPlanning.instance.LenP4() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask4();
                }
                else Debug.Log("already picked a task");
            
        }
        #endregion



    }
}
