using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class P1Menu : MonoBehaviour {

    PersonalPlanning planning;
    TaskSpot[] spotsP1;
    public TaskSpot spot1;
    public TaskSpot spot2;
    public TaskSpot spot3;
    public TaskSpot spot4;
    public TaskSpot spot5;

    public PauseScript pause;
    public GameObject p1Menu;
    public GameObject player;
    public GameObject player1;

    private Rigidbody task;
    private float xShot = 1.5f;
    private float throwSpeed = 10;

    public Button task1;
    //public GameObject taskObj1;
    public Button task2;
    //public GameObject taskObj2;
    public Button task3;
    //public GameObject taskObj3;
    public Button task4;
    //public GameObject taskObj4;
    public Button task5;
    //public GameObject taskObj5;
    // Use this for initialization
    void Start ()
    {
        planning = PersonalPlanning.instance;
        player = GameObject.FindGameObjectWithTag("Player1");
        spotsP1 = player1.GetComponentsInChildren<TaskSpot>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        UpdateUI1();
        if (pause.isPaused)
        {
            p1Menu.SetActive(true);
            //Time.timeScale = 0f;
            Debug.Log(Time.timeScale);

            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
                ThrowTask1(spot1);
            }
            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                ThrowTask1(spot2);
            }
            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                ThrowTask1(spot3);
            }
            if (Input.GetKeyUp(KeyCode.Alpha4))
            {
                ThrowTask1(spot4);
            }
            if (Input.GetKeyUp(KeyCode.Alpha5))
            {
                ThrowTask1(spot5);
            }
        }
        else
        {
            p1Menu.SetActive(false);
            //Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            pause.isPaused = !pause.isPaused;
        }

    }

    public void ThrowTask1(TaskSpot spot)
    {
        task = spot.GetTask().GetComponent<Rigidbody>();
        Rigidbody taskThrow = Instantiate(task, new Vector3(player.transform.position.x + xShot, player.transform.position.y, player.transform.position.z), Quaternion.identity) as Rigidbody;
        //taskThrow.AddForce(player.transform.right * throwSpeed);
        taskThrow.velocity = (new Vector3(throwSpeed, 6.5f, 0));
        //throwSpeed *= 0.8f;
        pause.isPaused = !pause.isPaused;
        spot.OnTaskThrowP1();
        
    }

    void UpdateUI1()
    {
        //Debug.Log("updating UI1");

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
}
