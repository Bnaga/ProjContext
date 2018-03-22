using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P2Menu : MonoBehaviour {

    PersonalPlanning planning;
    TaskSpot[] spotsP2;
    public TaskSpot spot1;
    public TaskSpot spot2;
    public TaskSpot spot3;
    public TaskSpot spot4;
    public TaskSpot spot5;

    public bool p1Paused = false;
    public GameObject p2Menu;
    public GameObject player;
    public GameObject player2;

    private Rigidbody task;
    private float xShot = 1.5f;
    private float throwSpeed = 15;

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
    void Start()
    {
        planning = PersonalPlanning.instance;
        player = GameObject.FindGameObjectWithTag("Player2");
        spotsP2 = player2.GetComponentsInChildren<TaskSpot>();

    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI2();
        if (p1Paused)
        {
            p2Menu.SetActive(true);
            Time.timeScale = 0f;

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
            p2Menu.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            p1Paused = !p1Paused;
        }

    }

    public void ThrowTask1(TaskSpot spot)
    {
        task = spot.GetTask().GetComponent<Rigidbody>();
        Rigidbody taskThrow = Instantiate(task, new Vector3(player.transform.position.x + xShot, player.transform.position.y, player.transform.position.z), Quaternion.identity) as Rigidbody;
        //taskThrow.AddForce(player.transform.right * throwSpeed);
        taskThrow.velocity = (new Vector3(throwSpeed, 6.5f, 0));
        //throwSpeed *= 0.8f;
        p1Paused = !p1Paused;
        spot.OnTaskThrowP2();

    }

    void UpdateUI2()
    {
        //Debug.Log("updating UI1");

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
}
