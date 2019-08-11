using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillLapis : MonoBehaviour {

    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        //lapis = this.GetComponent<GameObject>();

    }
    //Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q");
            //lapis.active = true;
            //this.gameObject.SetActive(true);
            anim.SetInteger("Skill", 1);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("E");
            //lapis.active = true;
            //this.gameObject.SetActive(true);
            anim.SetInteger("Skill", 2);
        }
        //else
        //{
        //    lapis.SetActive(false);
        //}
    }

}
