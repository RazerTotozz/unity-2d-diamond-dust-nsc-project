using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial3 : MonoBehaviour {
    private int btnStatus;
    public GameObject text1, text2, text3, text4, text5, text6, text7;
    public GameObject circleInvent, circleSummon, circleFusion, circleStory, circleUpgrade;
    public GameObject locent, textBox, bg, nextBtn;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(btnStatus == 0)
        {
            text1.SetActive(true);
        }
        else if(btnStatus == 1)
        {
            text1.SetActive(false);
            text2.SetActive(true);
            circleInvent.SetActive(true);
        }
        else if(btnStatus == 2)
        {
            text2.SetActive(false);
            text3.SetActive(true);
            circleInvent.SetActive(false);
            circleFusion.SetActive(true);
        }
        else if(btnStatus == 3)
        {
            text3.SetActive(false);
            text4.SetActive(true);
            circleFusion.SetActive(false);
            circleUpgrade.SetActive(true);
        }
        else if(btnStatus == 4)
        {
            text4.SetActive(false);
            text5.SetActive(true);
            circleUpgrade.SetActive(false);
            circleStory.SetActive(true);
        }
        else if(btnStatus == 5)
        {
            text5.SetActive(false);
            text6.SetActive(true);
            circleStory.SetActive(false);
            circleSummon.SetActive(true);
        }
        else if(btnStatus == 6)
        {
            text6.SetActive(false);
            text7.SetActive(true);
            circleSummon.SetActive(false);
        }
        else if(btnStatus == 7)
        {
            text7.SetActive(false);
            locent.SetActive(false);
            textBox.SetActive(false);
            bg.SetActive(false);
            nextBtn.SetActive(false);
        }
    }

    public void Nextt()
    {
        btnStatus += 1;
        Debug.Log(btnStatus);
    }
}
