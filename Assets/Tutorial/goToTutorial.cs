using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToTutorial : MonoBehaviour {

    public bool clickRegis;
    private Scene gotoTuto;
    void Start()
    {
        clickRegis = false;
        gotoTuto = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickRegis == true)
        {
            Application.LoadLevel("Tutorial1");

        }
        if (clickRegis == false)
        {
            gotoTuto = SceneManager.GetActiveScene();
        }
    }
    public void goTuto1()
    {
        if (clickRegis == false)
        {
            clickRegis = true;
        }
        else
        {
            clickRegis = false;
        }
    }
}
