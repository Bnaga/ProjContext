using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour {

    public Task task;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag =="Player1")
        {
            //GetComponent<TaskPick>().PickTask1();
            bool pickUp = PersonalPlanning.instance.AddPlayer1(task);
            Debug.Log(pickUp);
            if (pickUp)
            {
                
                //Destroy(this.gameObject);
            }
            else Debug.Log("taskbar full");
        }
        if (collision.collider.tag == "Player2")
        {
            bool pickUp = PersonalPlanning.instance.AddPlayer2(task);
            if (pickUp)
            {
                //Destroy(this.gameObject);
            }
            else Debug.Log("taskbar full");
        }
        if (collision.collider.tag == "Player3")
        {
            bool pickUp = PersonalPlanning.instance.AddPlayer2(task);
            if (pickUp)
            {
                //Destroy(this.gameObject);
            }
            else Debug.Log("taskbar full");
        }
        if (collision.collider.tag == "Player4")
        {
            bool pickUp = PersonalPlanning.instance.AddPlayer2(task);
            if (pickUp)
            {
                //Destroy(this.gameObject);
            }
            else Debug.Log("taskbar full");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player1")
        {
            //GetComponent<TaskPick>().PickTask1();
            bool pickUp = PersonalPlanning.instance.AddPlayer1(task);
            Debug.Log(pickUp);
            if (pickUp)
            {

                Destroy(this.gameObject);
            }
            else Debug.Log("taskbar 1 full");
        }
        if (other.tag == "Player2")
        {
            bool pickUp = PersonalPlanning.instance.AddPlayer2(task);
            if (pickUp)
            {
                Destroy(this.gameObject);
            }
            else Debug.Log("taskbar 2 full");
        }
        if (other.tag == "Player3")
        {
            bool pickUp = PersonalPlanning.instance.AddPlayer3(task);
            if (pickUp)
            {
                Destroy(this.gameObject);
            }
            else Debug.Log("taskbar 3 full");
        }
        if (other.tag == "Player4")
        {
            bool pickUp = PersonalPlanning.instance.AddPlayer4(task);
            if (pickUp)
            {
                Destroy(this.gameObject);
            }
            else Debug.Log("taskbar 4 full");
        }
    }
}
