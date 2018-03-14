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

    public void PickTask()
    { 
    
        Debug.Log("Picking " +  task.name);
        bool wasPicked = PersonalPlanning.instance.Add(task);
        if (wasPicked)
        {
            button.interactable = false;
        }
    }
}
