using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoundTimer : MonoBehaviour {
    public float timeLim = 10;
    public float roundTime = 10;
    public RoundManager roundMan;
    public Text timer;
    public float timerTime = 0;
    public ButtonManager buttonMan;
    public int currentRound = 0;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    { 
        CountDown();
        timerTime = Mathf.Round(roundTime * 100.0f) / 100.0f;
        timer.text = timerTime.ToString();
    }

    void CountDown()
    {
        roundTime -= Time.deltaTime;
        if (roundMan.currentRound == 1 && roundTime <= 0)
        {
            CheckRound1();
            roundMan.currentRound = 2;
            roundMan.roundChange = true;
            roundTime = timeLim;
        }
        if (roundMan.currentRound == 2 && roundTime <= 0)
        {
            CheckRound2();
            roundMan.currentRound = 3;
            roundMan.roundChange = true;
            roundTime = timeLim;
        }
        if (roundMan.currentRound == 3 && roundTime <= 0)
        {
            CheckRound3();
            roundMan.currentRound = 4;
            roundMan.roundChange = true;
            roundTime = timeLim;
        }
        if (roundMan.currentRound == 4 && roundTime <= 0)
        {
            CheckRound4();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    void CheckRound1()
    {
        currentRound = roundMan.currentRound;
        if (buttonMan.round1green.enabled)
        {
            if(PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
        if (buttonMan.round1yellow.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow");
                task.GetComponent<TaskPick>().PickTask4();
            }

        }
        if (buttonMan.round1blue.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
        if (buttonMan.round1pink.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
    }

    void CheckRound2()
    {
        currentRound = roundMan.currentRound;
        if (buttonMan.round2green.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green2");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green2");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green2");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green2");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
        if (buttonMan.round2yellow.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow2");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow2");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow2");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow2");
                task.GetComponent<TaskPick>().PickTask4();
            }

        }
        if (buttonMan.round2blue.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue2");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue2");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue2");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue2");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
        if (buttonMan.round2pink.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink2");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink2");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink2");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink2");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
    }

    void CheckRound3()
    {
        currentRound = roundMan.currentRound;
        if (buttonMan.round3green.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green3");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green3");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green3");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green3");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
        if (buttonMan.round3yellow.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow3");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow3");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow3");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow3");
                task.GetComponent<TaskPick>().PickTask4();
            }

        }
        if (buttonMan.round3blue.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue3");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue3");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue3");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue3");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
        if (buttonMan.round3pink.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink3");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink3");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink3");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink3");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
    }

    void CheckRound4()
    {
        currentRound = roundMan.currentRound;
        if (buttonMan.round4green.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green4");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green4");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green4");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("green4");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
        if (buttonMan.round4yellow.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow4");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow4");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow4");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("yellow4");
                task.GetComponent<TaskPick>().PickTask4();
            }

        }
        if (buttonMan.round4blue.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue4");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue4");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue4");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("blue4");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
        if (buttonMan.round4pink.enabled)
        {
            if (PersonalPlanning.instance.LenP1() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink4");
                task.GetComponent<TaskPick>().PickTask1();
            }

            if (PersonalPlanning.instance.LenP2() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink4");
                task.GetComponent<TaskPick>().PickTask2();
            }

            if (PersonalPlanning.instance.LenP3() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink4");
                task.GetComponent<TaskPick>().PickTask3();
            }

            if (PersonalPlanning.instance.LenP4() < roundMan.currentRound)
            {
                GameObject task = GameObject.FindGameObjectWithTag("pink4");
                task.GetComponent<TaskPick>().PickTask4();
            }
        }
    }
}
