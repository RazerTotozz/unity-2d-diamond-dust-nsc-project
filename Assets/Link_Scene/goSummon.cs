using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goSummon : MonoBehaviour {

    public static bool clickSummon;
    private Scene gotoSummon;
    void Start()
    {
        clickSummon = false;
        gotoSummon = SceneManager.GetActiveScene();

    }
    void Update()
    {
        if (clickSummon == true)
        {
            Application.LoadLevel("Summon");

        }
        if (clickSummon == false)
        {
            gotoSummon = SceneManager.GetActiveScene();
        }
    }
    public void goSummoon()
    {
        if (clickSummon == false)
        {
            clickSummon = true;
        }
        else
        {
            clickSummon= false;
        }
    }
}
