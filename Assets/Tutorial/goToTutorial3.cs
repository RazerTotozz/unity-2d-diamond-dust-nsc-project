using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToTutorial3 : MonoBehaviour {

    public static bool clickTuto3;
    private Scene gotoTuto3;
    void Start()
    {
        clickTuto3 = false;
        gotoTuto3 = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickTuto3 == true)
        {
            Application.LoadLevel("Tutorial3");

        }
        if (clickTuto3 == false)
        {
            gotoTuto3 = SceneManager.GetActiveScene();
        }
    }
    public void goTuto3()
    {
        if (clickTuto3 == false)
        {
            clickTuto3 = true;
        }
        else
        {
            clickTuto3 = false;
        }
    }
}
