using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goFusion : MonoBehaviour {

    public static bool clickFusion;
    private Scene gotoFusion;
    void Start()
    {
        clickFusion = false;
        gotoFusion = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickFusion == true)
        {
            Application.LoadLevel("Fusion");

        }
        if (clickFusion == false)
        {
            gotoFusion = SceneManager.GetActiveScene();
        }
    }
    public void goFusionn()
    {
        if (clickFusion == false)
        {
            clickFusion = true;
        }
        else
        {
            clickFusion = false;
        }
    }
}
