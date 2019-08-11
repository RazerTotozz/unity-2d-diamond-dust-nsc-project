using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goUpgrade : MonoBehaviour {

    public static bool clickUpgrade;
    private Scene gotoUpgrade;
    void Start()
    {
        clickUpgrade = false;
        gotoUpgrade = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickUpgrade == true)
        {
            Application.LoadLevel("Upgrade");

        }
        if (clickUpgrade == false)
        {
            gotoUpgrade = SceneManager.GetActiveScene();
        }
    }
    public void goUpgradede()
    {
        if (clickUpgrade == false)
        {
            clickUpgrade = true;
        }
        else
        {
            clickUpgrade = false;
        }
    }
}
