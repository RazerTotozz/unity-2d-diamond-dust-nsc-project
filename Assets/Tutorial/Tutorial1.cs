using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial1 : MonoBehaviour {

    private int btnStatus;
    public GameObject text1, text2, text3;
    public GameObject circle1, circle2, circle3;
    public GameObject locent, textbox, nextbtn, BG;
	// Use this for initialization
	void Start () {
        btnStatus = 0;
        circle1.SetActive(false);
        circle2.SetActive(false);
        circle3.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if(btnStatus == 0)
        {
            locent.SetActive(true);
            textbox.SetActive(true);
            nextbtn.SetActive(true);
            text1.SetActive(true);
            text2.SetActive(false);
            text3.SetActive(false);

        }
        if(btnStatus == 1)
        {
            text1.SetActive(false);
            text2.SetActive(true);
            circle1.SetActive(true);
            BG.SetActive(false);
            locent.SetActive(false);

        }
        if(btnStatus == 2)
        {
            text2.SetActive(false);
            text3.SetActive(true);
            circle1.SetActive(false);
            circle2.SetActive(true);
            circle3.SetActive(true);
        }


    }

    public void Nextt()
    {
        btnStatus += 1;
        Debug.Log(btnStatus);
    }
}
