using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour {

    public Button round2green;
    public Button round2yellow;
    public Button round2blue;
    public Button round2pink;
    public Button round3green;
    public Button round3yellow;
    public Button round3blue;
    public Button round3pink;
    public Button round4green;
    public Button round4yellow;
    public Button round4blue;
    public Button round4pink;

    public int currentRound = 1;
    public bool roundChange = false;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Jump") && currentRound < 4)
        {
            currentRound += 1;
            Debug.Log(currentRound);
            roundChange = true;
        }

        if(currentRound == 2 && roundChange)
        {
            round2green.interactable = true;
            round2yellow.interactable = true;
            round2blue.interactable = true;
            round2pink.interactable = true;
            roundChange = false;
        }

        if (currentRound == 3 && roundChange)
        {
            round3green.interactable = true;
            round3yellow.interactable = true;
            round3blue.interactable = true;
            round3pink.interactable = true;
            roundChange = false;
        }

        if (currentRound == 4 && roundChange)
        {
            round4green.interactable = true;
            round4yellow.interactable = true;
            round4blue.interactable = true;
            round4pink.interactable = true;
            roundChange = false;
        }
    }
}


