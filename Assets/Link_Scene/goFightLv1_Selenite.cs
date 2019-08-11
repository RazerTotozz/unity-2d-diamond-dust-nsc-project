using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goFightLv1_Selenite : MonoBehaviour {

    public static bool clickFight;
    private Scene gotoFight;
    void Start()
    {
        clickFight = false;
        gotoFight = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickFight == true)
        {
            Application.LoadLevel("Level1_selenite");

        }
        if (clickFight == false)
        {
            gotoFight = SceneManager.GetActiveScene();
        }
    }
    public void goFightt()
    {
        if (clickFight == false)
        {
            clickFight = true;
        }
        else
        {
            clickFight = false;
        }
    }
}
