using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlannerUI : MonoBehaviour {

    public Transform player1;
    public Transform player2;
    public Transform player3;
    public Transform player4;

    PersonalPlanning planning;

    TaskSpot[] spotsP1;
    TaskSpot[] spotsP2;
    TaskSpot[] spotsP3;
    TaskSpot[] spotsP4;
    // Use this for initialization
    void Start () {
        planning = PersonalPlanning.instance;
        planning.onTaskChangedCallback1 += UpdateUI1;
        planning.onTaskChangedCallback2 += UpdateUI2;
        planning.onTaskChangedCallback3 += UpdateUI3;
        planning.onTaskChangedCallback4 += UpdateUI4;

        spotsP1 = player1.GetComponentsInChildren<TaskSpot>();
        spotsP2 = player2.GetComponentsInChildren<TaskSpot>();
        spotsP3 = player3.GetComponentsInChildren<TaskSpot>();
        spotsP4 = player4.GetComponentsInChildren<TaskSpot>();
    }
	
	// Update is called once per frame
	void Update () {
		
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

    void UpdateUI2()
    {
        Debug.Log("updating UI2");

        for (int i = 0; i < spotsP2.Length; i++)
        {
            if (i < planning.tasksP2.Count)
            {
                spotsP2[i].AddTask(planning.tasksP2[i]);
            }
            else
            {
                spotsP2[i].ClearSpot();
            }
        }
    }
    void UpdateUI3()
    {
        Debug.Log("updating UI3");

        for (int i = 0; i < spotsP3.Length; i++)
        {
            if (i < planning.tasksP3.Count)
            {
                spotsP3[i].AddTask(planning.tasksP3[i]);
            }
            else
            {
                spotsP3[i].ClearSpot();
            }
        }
    }
    void UpdateUI4()
    {
        Debug.Log("updating UI4");

        for (int i = 0; i < spotsP4.Length; i++)
        {
            if (i < planning.tasksP4.Count)
            {
                spotsP4[i].AddTask(planning.tasksP4[i]);
            }
            else
            {
                spotsP4[i].ClearSpot();
            }
        }
    }
}
