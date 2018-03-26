using UnityEngine;


[CreateAssetMenu(fileName = "New Task", menuName ="Planner/Task")]
public class Task : ScriptableObject
{
    public string taskName = "New Task";
    public Sprite icon = null;
    public bool isDefaultTask = false;
    public GameObject task;
    [Range(0, 0.2f)]
    public float weight = 0;
}
