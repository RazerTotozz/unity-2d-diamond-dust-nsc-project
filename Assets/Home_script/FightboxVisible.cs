using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightboxVisible : MonoBehaviour {
    private bool btnStatus;
    public GameObject selectBox;
	// Use this for initialization
	void Start () {
        btnStatus = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(btnStatus == false){
            selectBox.active = false;
        }
        if(btnStatus == true){
            selectBox.active = true;
        }
	}

    public void fightboxx(){
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
