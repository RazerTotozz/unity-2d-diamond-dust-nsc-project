﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goInventory : MonoBehaviour {

    public static bool clickInventory;
    private Scene gotoInventory;
    void Start()
    {
        clickInventory = false;
        gotoInventory = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickInventory == true)
        {
            Application.LoadLevel("Inventory2");

        }
        if (clickInventory == false)
        {
            gotoInventory = SceneManager.GetActiveScene();
        }
    }
    public void goInvent()
    {
        if (clickInventory == false)
        {
            clickInventory = true;
        }
        else
        {
            clickInventory = false;
        }
    }
}
