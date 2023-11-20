using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_change_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SceneChange()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "mouse")
        {
            SceneManager.LoadScene("laser");
        }

        if (sceneName == "laser")
        {
            SceneManager.LoadScene("pet");
        }

        if (sceneName == "pet")
        {
            SceneManager.LoadScene("turtle");
        }

        if (sceneName == "turtle")
        {
            SceneManager.LoadScene("flashlight");
        }

        if (sceneName == "flashlight")
        {
            SceneManager.LoadScene("bird");
        }
    }
}
