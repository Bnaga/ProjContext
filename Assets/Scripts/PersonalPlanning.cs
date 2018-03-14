using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalPlanning : MonoBehaviour {

    #region Singleton
    public static PersonalPlanning instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("more than one instance of planning found!");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnTaskChanged();
    public OnTaskChanged onTaskChangedCallback;

    public int space = 5;

    public List<Task> tasks = new List<Task>();

    public bool Add(Task task)
    {
        if (!task.isDefaultTask)
        {
            if(tasks.Count >= space)
            {
                Debug.Log("planning full");
                return false;
            }
            tasks.Add(task);

            if (onTaskChangedCallback != null)
            {
                onTaskChangedCallback.Invoke();
            }
        }
        return true;
    }

    public void Remove(Task task)
    {
        tasks.Remove(task);

        if (onTaskChangedCallback != null)
        {
            onTaskChangedCallback.Invoke();
        }
    }
}
