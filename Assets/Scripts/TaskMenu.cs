using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TaskMenu : MonoBehaviour {

    public bool isPaused;
    public GameObject pauseMenuCanvas;
    public Rigidbody task;
    private float xShot = 1.5f;
    private float throwSpeed = 15;
    public GameObject player;
    // Use this for initialization
    public Button task1;
    public GameObject taskObj1;
    public Button task2;
    public GameObject taskObj2;
    public Button task3;
    public GameObject taskObj3;
    public Button task4;
    public GameObject taskObj4;
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player1");
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isPaused = !isPaused;
        }

        if (EventSystem.current.currentSelectedGameObject == null)
        {
            Debug.Log("Reselecting first input");
            if(!task1.interactable)
            {
                EventSystem.current.SetSelectedGameObject(taskObj2);
            }
            if (!task1.interactable && !task2.interactable)
            {
                EventSystem.current.SetSelectedGameObject(taskObj3);
            }
            if (!task1.interactable && !task2.interactable && !task3.interactable)
            {
                EventSystem.current.SetSelectedGameObject(taskObj4);
            }
        }
    }

    public void ThrowTask1()
    {
        Rigidbody taskThrow = Instantiate(task, new Vector3(player.transform.position.x + xShot, player.transform.position.y, player.transform.position.z), Quaternion.identity) as Rigidbody;
        //taskThrow.AddForce(player.transform.right * throwSpeed);
        taskThrow.velocity = (new Vector3(throwSpeed, 6.5f, 0));
        //throwSpeed *= 0.8f;
        isPaused = !isPaused;
        task1.interactable = false;
    }

    void ThrowTask2()
    {

    }
    void ThrowTask3()
    {

    }
    void ThrowTask4()
    {

    }
}
