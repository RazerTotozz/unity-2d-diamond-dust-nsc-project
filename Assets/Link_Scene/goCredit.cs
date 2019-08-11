using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goCredit : MonoBehaviour {

    public static bool clickCredit;
    private Scene gotoCredit;
    void Start()
    {
        clickCredit = false;
        gotoCredit = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickCredit == true)
        {
            Application.LoadLevel("Credit");

        }
        if (clickCredit == false)
        {
            gotoCredit = SceneManager.GetActiveScene();
        }
    }
    public void goCreditt()
    {
        if (clickCredit == false)
        {
            clickCredit = true;
        }
        else
        {
            clickCredit = false;
        }
    }
}
