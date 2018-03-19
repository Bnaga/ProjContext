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
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        rbody.velocity = new Vector3(wallSpeed, 0, 0);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag.Contains("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
