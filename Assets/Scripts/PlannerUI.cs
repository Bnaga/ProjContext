using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlannerUI : MonoBehaviour {

    PersonalPlanning planning;
	// Use this for initialization
	void Start () {
        planning = PersonalPlanning.instance;
        planning.onTaskChangedCallback += UpdateUI;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void UpdateUI()
    {
        Debug.Log("updating UI");
    }
}
