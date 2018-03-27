using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalPlanning : MonoBehaviour {

    #region Singleton
    public static PersonalPlanning instance;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if(instance != null)
        {
            Debug.LogWarning("more than one instance of planning found!");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnTaskChanged();
    public OnTaskChanged onTaskChangedCallback1;
    public OnTaskChanged onTaskChangedCallback2;
    public OnTaskChanged onTaskChangedCallback3;
    public OnTaskChanged onTaskChangedCallback4; 

    public int space = 5;

    public List<Task> tasksP1 = new List<Task>();
    public List<Task> tasksP2 = new List<Task>();
    public List<Task> tasksP3 = new List<Task>();
    public List<Task> tasksP4 = new List<Task>();


    #region AddTasktoPlayers
    public bool AddPlayer1(Task task)
    {
        if (!task.isDefaultTask)
        {
            if(tasksP1.Count >= space)
            {
                Debug.Log("planning full");
                return false;
            }
            tasksP1.Add(task);

            if (onTaskChangedCallback1 != null)
            {
                onTaskChangedCallback1.Invoke();
            }
        }
        return true;
    }

    public bool AddPlayer2(Task task)
    {
        if (!task.isDefaultTask)
        {
            if (tasksP2.Count >= space)
            {
                Debug.Log("planning full");
                return false;
            }
            tasksP2.Add(task);

            if (onTaskChangedCallback2 != null)
            {
                onTaskChangedCallback2.Invoke();
            }
        }
        return true;
    }

    public bool AddPlayer3(Task task)
    {
        if (!task.isDefaultTask)
        {
            if (tasksP3.Count >= space)
            {
                Debug.Log("planning full");
                return false;
            }
            tasksP3.Add(task);

            if (onTaskChangedCallback3 != null)
            {
                onTaskChangedCallback3.Invoke();
            }
        }
        return true;
    }

    public bool AddPlayer4(Task task)
    {
        if (!task.isDefaultTask)
        {
            if (tasksP4.Count >= space)
            {
                Debug.Log("planning full");
                return false;
            }
            tasksP4.Add(task);

            if (onTaskChangedCallback4 != null)
            {
                onTaskChangedCallback4.Invoke();
            }
        }
        return true;
    }
    #endregion

    #region RemoveTasks
    public void RemoveP1(Task task)
    {
        tasksP1.Remove(task);

        if (onTaskChangedCallback1 != null)
        {
            onTaskChangedCallback1.Invoke();
        }
    }

    public void RemoveP2(Task task)
    {
        tasksP2.Remove(task);

        if (onTaskChangedCallback2 != null)
        {
            onTaskChangedCallback2.Invoke();
        }
    }

    public void RemoveP3(Task task)
    {
        tasksP3.Remove(task);

        if (onTaskChangedCallback3 != null)
        {
            onTaskChangedCallback3.Invoke();
        }
    }

    public void RemoveP4(Task task)
    {
        tasksP4.Remove(task);

        if (onTaskChangedCallback4 != null)
        {
            onTaskChangedCallback4.Invoke();
        }
    }
    #endregion

    #region LengthTasks
    public int LenP1()
    {
        return tasksP1.Count;
    }

    public int LenP2()
    {
        return tasksP2.Count;
    }
    public int LenP3()
    {
        return tasksP3.Count;
    }
    public int LenP4()
    {
        return tasksP4.Count;
    }
    #endregion

    #region getWeight

    public float GetWeightP1()
    {
        float thisWeight = 0;
        for (int i = 0; i< tasksP1.Count; i++)
        {
            thisWeight += tasksP1[i].weight;
        }

        return thisWeight;
    }

    public float GetWeightP2()
    {
        float thisWeight = 0;
        for (int i = 0; i < tasksP2.Count; i++)
        {
            thisWeight += tasksP2[i].weight;
        }

        return thisWeight;
    }

    public float GetWeightP3()
    {
        float thisWeight = 0;
        for (int i = 0; i < tasksP3.Count; i++)
        {
            thisWeight += tasksP3[i].weight;
        }

        return thisWeight;
    }

    public float GetWeightP4()
    {
        float thisWeight = 0;
        for (int i = 0; i < tasksP4.Count; i++)
        {
            thisWeight += tasksP4[i].weight;
        }

        return thisWeight;
    }

    #endregion
}
