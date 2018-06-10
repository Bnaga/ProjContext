using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallScript : MonoBehaviour {

    public Rigidbody rbody;
    public float wallSpeed = 5;
	// Use this for initialization
	void Start () {
        rbody = this.gameObject.GetComponent<Rigidbody>();
	}

    private void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        //rbody.velocity = new Vector3(wallSpeed, 0, 0);
	}

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag.Contains("Player"))
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Destroy(collider.gameObject);
        }
    }

    
}
