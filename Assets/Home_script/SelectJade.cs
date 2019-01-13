using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectJade : MonoBehaviour {

    public bool btnJade;
    public GameObject greenBoxJ;
    public GameObject Jade;
    public GameObject btnDefault;
    // Use this for initialization
    void Start()
    {
        btnJade = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (btnJade == false)
        {
            greenBoxJ.active = false;
            Jade.active = false;
            btnDefault.active = true;
        }
        if (btnJade == true)
        {
            greenBoxJ.active = true;
            Jade.active = true;
            btnDefault.active = false;
        }
    }

    public void clickJade()
    {
        if (btnJade == false)
        {
            btnJade = true;
        }
        else
        {
            btnJade = false;
        }
    }

    public bool getJadeStatus(){
        return btnJade;
    }

    public void setJadeStatus(bool newJadeStatus){
        btnJade = newJadeStatus;
    }
}
