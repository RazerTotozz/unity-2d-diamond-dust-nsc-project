using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSelenite : MonoBehaviour {
    public bool btnSe;
    public GameObject greenBoxS;
    public GameObject Selenite;
    public GameObject btnDefault;
    // Use this for initialization
    void Start()
    {
        btnSe = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (btnSe == false)
        {
            greenBoxS.active = false;
            Selenite.active = false;
            btnDefault.active = true;
        }
        if (btnSe == true)
        {
            greenBoxS.active = true;
            Selenite.active = true;
            btnDefault.active = false;
        }
    }

    public void clickSelenite()
    {
        if (btnSe == false)
        {
            btnSe = true;
        }
        else
        {
            btnSe = false;
        }
    }

    public bool getSeleniteStatus()
    {
        return btnSe;
    }

    public void setSStatus(bool newSeStatus)
    {
        btnSe = newSeStatus;
    }
}
