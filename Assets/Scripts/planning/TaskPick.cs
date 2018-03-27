using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskPick : MonoBehaviour {

    public Task task;
    public Button button;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PickTask1()
    {
        if (button.interactable)
        {
            Debug.Log("Picking " + task.name);
            bool wasPicked = PersonalPlanning.instance.AddPlayer1(task);
            if (wasPicked)
            {
                button.interactable = false;
            }
        }
        else
        {
            Debug.Log("already chosen");
        }
    }

    public void PickTask2()
    {
        if (button.interactable)
        {
            Debug.Log("Picking " + task.name);
            bool wasPicked = PersonalPlanning.instance.AddPlayer2(task);
            if (wasPicked)
            {
                button.interactable = false;
            }
        }
        else
        {
            Debug.Log("already chosen");
        }
    }

    public void PickTask3()
    {
        if (button.interactable)
        {
            Debug.Log("Picking " + task.name);
            bool wasPicked = PersonalPlanning.instance.AddPlayer3(task);
            if (wasPicked)
            {
                button.interactable = false;
            }
        }
        else
        {
            Debug.Log("already chosen");
        }
    }

    public void PickTask4()
    {
        if (button.interactable)
        {
            Debug.Log("Picking " + task.name);
            bool wasPicked = PersonalPlanning.instance.AddPlayer4(task);
            if (wasPicked)
            {
                button.interactable = false;
            }
        }
        else
        {
            Debug.Log("already chosen");
        }
    }
}
