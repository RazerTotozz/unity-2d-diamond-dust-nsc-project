using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToTutorial2 : MonoBehaviour {

    public static bool clickTuto2;
    private Scene gotoTuto2;
    void Start()
    {
        clickTuto2 = false;
        gotoTuto2 = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickTuto2 == true)
        {
            Application.LoadLevel("Tutorial2");

        }
        if (clickTuto2 == false)
        {
            gotoTuto2 = SceneManager.GetActiveScene();
        }
    }
    public void goTuto2()
    {
        if (clickTuto2 == false)
        {
            clickTuto2 = true;
        }
        else
        {
            clickTuto2 = false;
        }
    }
}
