using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour {
    private bool cStatus,sStatus,lStatus,jStatus;
    public GameObject greenBGC,greenBGS,greenBGL,greenBGJ;
    public GameObject nextBtn;
    public GameObject nextCinna,nextSelenite,nextLapis,nextJade;
	// Use this for initialization
	void Start () {
        cStatus = false;
        sStatus = false;
        lStatus = false;
        jStatus = false;

    }
	
	// Update is called once per frame
	void Update () {
        if (cStatus == false && sStatus == false && lStatus == false && jStatus == false)
        {
            greenBGC.active = false;
            greenBGS.active = false;
            greenBGL.active = false;
            greenBGJ.active = false;
            nextBtn.active = true;
            nextCinna.active = false;
            nextSelenite.active = false;
            nextLapis.active = false;
            nextJade.active = false;
        }
        if (cStatus == true)
        {
            greenBGC.active = true;
            greenBGS.active = false;
            greenBGL.active = false;
            greenBGJ.active = false;
            nextBtn.active = false;
            nextCinna.active = true;
            nextSelenite.active = false;
            nextLapis.active = false;
            nextJade.active = false;
        }
        if (cStatus == false)
        {
            greenBGC.active = false;
            nextCinna.active = false;
        }
        if (sStatus == true)
        {
            greenBGS.active = true;
            greenBGC.active = false;
            greenBGL.active = false;
            greenBGJ.active = false;
            nextBtn.active = false;
            nextCinna.active = false;
            nextSelenite.active = true;
            nextLapis.active = false;
            nextJade.active = false;
        }
        if (sStatus == false)
        {
            greenBGS.active = false;
            nextSelenite.active = false;

        }
        if (lStatus == true)
        {
            greenBGC.active = false;
            greenBGS.active = false;
            greenBGL.active = true;
            greenBGJ.active = false;
            nextBtn.active = false;
            nextCinna.active = false;
            nextSelenite.active = false;
            nextLapis.active = true;
            nextJade.active = false;
        }
        if(lStatus == false)
        {
            greenBGL.active = false;
            nextLapis.active = false;
        }
        if(jStatus == true)
        {
            greenBGC.active = false;
            greenBGS.active = false;
            greenBGL.active = false;
            greenBGJ.active = true;
            nextBtn.active = false;
            nextCinna.active = false;
            nextSelenite.active = false;
            nextLapis.active = false;
            nextJade.active = true;
        }
        if(jStatus == false)
        {
            greenBGJ.active = false;
            nextJade.active = false;
        }
    }

    public void NextCinna(){
        if (cStatus == false)
        {
            cStatus = true;

        }
        else
        {
            cStatus = false;
        }
        sStatus = false;
        lStatus = false;
        jStatus = false;


    }
    public void NextSelenite()
    {
        if (sStatus == false)
        {
            sStatus = true;
        }
        else{
            sStatus = false;
        }
        cStatus = false;
        lStatus = false;
        jStatus = false;

    }
    public void NextLapis()
    {
        if (lStatus == false)
        {
            lStatus = true;
        }
        else{
            lStatus = false;
        }
        cStatus = false;
        sStatus = false;
        jStatus = false;
    }
    public void NextJade()
    {
        if (jStatus == false)
        {
            jStatus = true;
        }
        else{
            jStatus = false;
        }
        cStatus = false;
        sStatus = false;
        lStatus = false;
    }
}
