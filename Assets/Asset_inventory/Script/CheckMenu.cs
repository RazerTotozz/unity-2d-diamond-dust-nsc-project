using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMenu : ChangeMenu {

    public GameObject allElement, allFairy;
    public GameObject onElementBtn, onFairyBtn;
    public GameObject offElementBtn, offFairyBtn;

    // Use this for initialization
    void Start () {
        atElement = true;
	}
	
	// Update is called once per frame
        void Update()
        {
            if (atElement)
            {
                Debug.Log("true");
                allElement.SetActive(true);
                allFairy.SetActive(false);
                onElementBtn.SetActive(true);
                offFairyBtn.SetActive(true);
                onFairyBtn.SetActive(false);
                offElementBtn.SetActive(false);
            }
            else //if(atElement == false)
            {
                Debug.Log("false");
                allElement.SetActive(false);
                allFairy.SetActive(true);
                onElementBtn.SetActive(false);
                offFairyBtn.SetActive(false);
                onFairyBtn.SetActive(true);
                offElementBtn.SetActive(true);
            }
        }
}
