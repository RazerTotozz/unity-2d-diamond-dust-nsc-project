using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSelect : MonoBehaviour {
    public SelectCinna Cinna;
    public SelectSelenite Selenite;
    public SelectLapis Lapis;
    public SelectJade Jade;
    // Use this for initialization
    void Start () {
	}

    // Update is called once per frame
    void Update() {
        if(Cinna.btnCin){
            Selenite.btnSe = false;
            Lapis.btnLa = false;
            Jade.btnJade = false;
        }
        if (Selenite.btnSe)
        {
            Cinna.btnCin = false;
            Lapis.btnLa = false;
            Jade.btnJade = false;
        }
        if (Lapis.btnLa)
        {
            Selenite.btnSe = false;
            Cinna.btnCin = false;
            Jade.btnJade = false;
        }
        if (Jade.btnJade)
        {
            Selenite.btnSe = false;
            Lapis.btnLa = false;
            Cinna.btnCin = false;
        }
    }
}
