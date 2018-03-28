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

        //player controlls
        #region Player1

        if (Input.GetKeyUp("a"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("green"); ;
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("green2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("green3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("green4");
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
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("yellow2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("yellow3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("yellow4");
            }

            if (PersonalPlanning.instance.LenP1() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask1();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKey("s"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("blue");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("blue2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("blue3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("blue4");
            }

            if (PersonalPlanning.instance.LenP1() < currentRound)
            {
                task.GetComponent<TaskPick>().PickTask1();
            }
            else Debug.Log("already picked a task");

        }

        if (Input.GetKey("d"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("pink");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("pink2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("pink3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("pink4");
            }

            if (PersonalPlanning.instance.LenP1() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask1();
                }
                else Debug.Log("already picked a task");

        }
        #endregion

        #region Player3

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {

            GameObject task = GameObject.FindGameObjectWithTag("green");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("green2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("green3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("green4");
            }

            if (PersonalPlanning.instance.LenP3() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask3();
                }
            else Debug.Log("already picked a task");
            
        }


        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            GameObject task = GameObject.FindGameObjectWithTag("yellow");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("yellow2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("yellow3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("yellow4");
            }

            if (PersonalPlanning.instance.LenP3() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask3();
                }
            else Debug.Log("already picked a task");

        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            GameObject task = GameObject.FindGameObjectWithTag("blue");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("blue2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("blue3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("blue4");
            }

            if (PersonalPlanning.instance.LenP3() < currentRound)
            {
                task.GetComponent<TaskPick>().PickTask3();
            }
            else Debug.Log("already picked a task");

        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GameObject task = GameObject.FindGameObjectWithTag("pink");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("pink2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("pink3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("pink4");
            }

            if (PersonalPlanning.instance.LenP3() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask3();
                }
            else Debug.Log("already picked a task");
            
        }
        #endregion

        #region Player4

        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            GameObject task = GameObject.FindGameObjectWithTag("green");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("green2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("green3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("green4");
            }

            if (PersonalPlanning.instance.LenP4() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask4();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            GameObject task = GameObject.FindGameObjectWithTag("yellow");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("yellow2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("yellow3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("yellow4");
            }

            if (PersonalPlanning.instance.LenP4() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask4();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            GameObject task = GameObject.FindGameObjectWithTag("blue");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("blue2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("blue3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("blue4");
            }

            if (PersonalPlanning.instance.LenP4() < currentRound)
            {
                task.GetComponent<TaskPick>().PickTask4();
            }
            else Debug.Log("already picked a task");

        }

        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            GameObject task = GameObject.FindGameObjectWithTag("pink");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("pink2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("pink3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("pink4");
            }

            if (PersonalPlanning.instance.LenP4() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask4();
                }
                else Debug.Log("already picked a task");
            
        }
        #endregion

        #region Player2

        if (Input.GetKeyUp("j"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("green");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("green2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("green3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("green4");
            }

            if (PersonalPlanning.instance.LenP2() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask2();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKey("i"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("yellow");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("yellow2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("yellow3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("yellow4");
            }

            if (PersonalPlanning.instance.LenP2() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask2();
                }
                else Debug.Log("already picked a task");
            
        }

        if (Input.GetKey("k"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("blue");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("blue2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("blue3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("blue4");
            }

            if (PersonalPlanning.instance.LenP2() < currentRound)
            {
                task.GetComponent<TaskPick>().PickTask2();
            }
            else Debug.Log("already picked a task");

        }


        if (Input.GetKey("l"))
        {
            GameObject task = GameObject.FindGameObjectWithTag("pink");
            if (currentRound == 2)
            {
                task = GameObject.FindGameObjectWithTag("pink2");
            }
            if (currentRound == 3)
            {
                task = GameObject.FindGameObjectWithTag("pink3");
            }
            if (currentRound == 4)
            {
                task = GameObject.FindGameObjectWithTag("pink4");
            }

            if (PersonalPlanning.instance.LenP2() < currentRound)
                {
                    task.GetComponent<TaskPick>().PickTask2();
                }
                else Debug.Log("already picked a task");
            
        }
        #endregion



    }
}
