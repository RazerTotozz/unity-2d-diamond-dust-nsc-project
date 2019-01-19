using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itemdisapear : MonoBehaviour {

    public GameObject Crys;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.collider.CompareTag("Player"))
    //    {
    //        Crys.SetActive(false);
    //    }

    //}

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Crys.SetActive(false);
        }
    }
}
