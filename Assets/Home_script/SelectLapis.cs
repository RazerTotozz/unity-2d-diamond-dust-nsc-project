using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLapis : MonoBehaviour {
    public bool btnLa;
    public GameObject greenBoxL;
    public GameObject Lapis;
    public GameObject btnDefault;
    // Use this for initialization
    void Start()
    {
        btnLa = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (btnLa == false)
        {
            greenBoxL.active = false;
            Lapis.active = false;
            btnDefault.active = true;
        }
        if (btnLa == true)
        {
            greenBoxL.active = true;
            Lapis.active = true;
            btnDefault.active = false;
        }
    }

    public void clickLapis()
    {
        if (btnLa == false)
        {
            btnLa = true;
        }
        else
        {
            btnLa = false;
        }
    }

    public bool getLapisStatus()
    {
        return btnLa;
    }

    public void setLapisStatus(bool newLapisStatus)
    {
        btnLa = newLapisStatus;
    }
}
