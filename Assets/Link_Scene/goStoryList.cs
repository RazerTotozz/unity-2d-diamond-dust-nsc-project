using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goStoryList : MonoBehaviour {

    public static bool clickStory;
    private Scene gotoStory;
    void Start()
    {
        clickStory = false;
        gotoStory = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickStory == true)
        {
            Application.LoadLevel("StoryMenu");

        }
        if (clickStory == false)
        {
            gotoStory = SceneManager.GetActiveScene();
        }
    }
    public void goStoryy()
    {
        if (clickStory == false)
        {
            clickStory = true;
        }
        else
        {
            clickStory = false;
        }
    }
}
