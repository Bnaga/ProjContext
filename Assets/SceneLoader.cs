using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour {

    private bool loadScene = false;

    [SerializeField]
    private int scene;
    [SerializeField]
    private Text loadingText;

    // Update is called once per frame
    void Update()
    {


        //If the player has pressed the space bar and a new scene is not loading yet
        if (Input.GetMouseButtonDown(0) && loadScene == false)
        {
            //set the loadScene boolean to true to prevent loading a new scene
            loadScene = true;

            loadingText.text = "LOADING...";

            StartCoroutine(LoadNewScene());
        }

        if (loadScene == true)
        {
            loadingText.color = new Color(loadingText.color.r, loadingText.color.g, loadingText.color.b, Mathf.PingPong(Time.time, 1));
            
        }
    }

        // The coroutine runs on its own at the same time as Update() and takes an integer indicating which scene to load.
        IEnumerator LoadNewScene()
        {

        // This line waits for 3 seconds before executing the next line in the coroutine.
        // This line is only necessary for this demo. The scenes are so simple that they load too fast to read the "Loading..." text.
        yield return new WaitForSeconds(3);

        // Start an asynchronous operation to load the scene that was passed to the LoadNewScene coroutine.
        AsyncOperation async = Application.LoadLevelAsync(scene);

            // While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
            while (!async.isDone)
            {
                yield return null;
            }

        }
    }
