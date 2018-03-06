using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskFade : MonoBehaviour {

    public bool isActive = false;
    Image image;
	// Use this for initialization
	void Start ()
    {
        image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(!isActive)
        {
            Color c = image.color;
            c.a = 0.5f;
            image.color = c;
        }
	}
}
