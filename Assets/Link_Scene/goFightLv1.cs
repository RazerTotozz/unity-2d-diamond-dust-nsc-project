﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goFightLv1 : MonoBehaviour {

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
            Application.LoadLevel("Level1");

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
