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
}
