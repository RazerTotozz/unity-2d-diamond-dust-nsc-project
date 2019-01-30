using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingAppear : MonoBehaviour {

    private bool btnStatus;
    public GameObject settingBox;
	// Use this for initialization
	void Start () {
        btnStatus = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(btnStatus == true){
            settingBox.active = true;
        }
        if(btnStatus == false){
            settingBox.active = false;
        }
	}

    public void clickSetting(){
        if (btnStatus == false)
        {
            btnStatus = true;
        }
        else
        {
            btnStatus = false;
        }
    }
}
