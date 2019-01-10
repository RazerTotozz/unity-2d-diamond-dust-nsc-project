using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class goHome : MonoBehaviour
{
    public static bool clickLogin;
    private Scene gotoHome;
    void Start()
    {
        clickLogin = false;
        gotoHome = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickLogin == true)
        {
            Application.LoadLevel("Home");

        }
        if (clickLogin == false)
        {
            gotoHome = SceneManager.GetActiveScene();
        }
    }
    public void gohomee()
    {
        if (clickLogin == false)
        {
            clickLogin = true;
        }
        else
        {
            clickLogin = false;
        }
    }

}