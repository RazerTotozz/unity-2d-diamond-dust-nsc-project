using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFairy : MonoBehaviour {
    private int x = 0;
    public GameObject cinnabarN, seleniteN, lapisN, jadeN;
    public GameObject cinnabar, selenite, lapis, jade;
    // Use this for initialization
    void Start () {
        x = Random.Range(1, 4);
        Debug.Log(x);
    }
	
	// Update is called once per frame
	void Update () {
        if(x == 1){
            cinnabar.active = true;
            cinnabarN.active = true;
            selenite.active = false;
            seleniteN.active = false;
            lapis.active = false;
            lapisN.active = false;
            jade.active = false;
            jadeN.active = false;
        }
        if (x == 2)
        {
            cinnabar.active = false;
            cinnabarN.active = false;
            selenite.active = true;
            seleniteN.active = true;
            lapis.active = false;
            lapisN.active = false;
            jade.active = false;
            jadeN.active = false;
        }
        if (x == 3)
        {
            cinnabar.active = false;
            cinnabarN.active = false;
            selenite.active = false;
            seleniteN.active = false;
            lapis.active = true;
            lapisN.active = true;
            jade.active = false;
            jadeN.active = false;
        }
        if (x == 4)
        {
            cinnabar.active = false;
            cinnabarN.active = false;
            selenite.active = false;
            seleniteN.active = false;
            lapis.active = false;
            lapisN.active = false;
            jade.active = true;
            jadeN.active = true;
        }
    }
}
