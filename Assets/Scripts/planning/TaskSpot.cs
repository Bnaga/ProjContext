using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskSpot : MonoBehaviour {

    public Image icon;

    Task task;

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
