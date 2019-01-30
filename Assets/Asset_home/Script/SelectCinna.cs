using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCinna : MonoBehaviour {
    public bool btnCin;
    public GameObject greenBoxC;
    public GameObject Cinna;
    public GameObject btnDefault;
	// Use this for initialization
	void Start () {
        btnCin = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (btnCin == false){
            greenBoxC.active = false;
            Cinna.active = false;
            btnDefault.active = true;
        }
        if(btnCin == true){
            greenBoxC.active = true;
            Cinna.active = true;
            btnDefault.active = false;
        }
	}

    public void clickCinna (){
        if(btnCin == false){
            btnCin = true;
        }
        else{
            btnCin = false;
        }
    }

}
