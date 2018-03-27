using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskSpot : MonoBehaviour {

    public Image icon;

    Task task;

    public RunnerScript runner1;
    public RunnerScript3 runner2;
    public RunnerScript4 runner3;
    public RunnerScript2 runner4;

    void Start()
    {
        runner1 = GameObject.FindGameObjectWithTag("Player1").GetComponent<RunnerScript>();
        runner2 = GameObject.FindGameObjectWithTag("Player2").GetComponent<RunnerScript3>();
        runner3 = GameObject.FindGameObjectWithTag("Player3").GetComponent<RunnerScript4>();
        runner4 = GameObject.FindGameObjectWithTag("Player4").GetComponent<RunnerScript2>();
    }

    public void AddTask(Task newTask)
    {
        task = newTask;
        icon.sprite = task.icon;
        icon.enabled = true;
    }

    public void ClearSpot()
    {
        task = null;
        icon.sprite = null;
        icon.enabled = false;
    }

    public void OnTaskThrowP1()
    {
        PersonalPlanning.instance.RemoveP1(task);
    }
    public void OnTaskThrowP2()
    {
        PersonalPlanning.instance.RemoveP2(task);
    }
    public void OnTaskThrowP3()
    {
        PersonalPlanning.instance.RemoveP3(task);
    }
    public void OnTaskThrowP4()
    {
        PersonalPlanning.instance.RemoveP4(task);
    }

    public GameObject GetTask()
    {
        return task.task;
    }
}
