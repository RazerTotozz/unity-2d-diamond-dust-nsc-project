using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterWalk : MonoBehaviour {

    public Animator anim;

    public int hp = 200;
    public Vector3 speed = new Vector3(1 ,1 ,1);
    public bool CharacterDetected = false;
    public float rotation = 0f;
    public Transform t;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        t.eulerAngles = new Vector3(t.eulerAngles.x, t.eulerAngles.y, rotation);
        if (CharacterDetected)
        {
            anim.SetBool("isATK", true);
        } else 
        anim.SetBool("isATK", false);

        //Physics2D.IgnoreLayerCollision(0, 9);
    }


    //void OnTriggerEnter2D(Collider2D obj)
    //{
    //    if (obj.gameObject.tag == "Player")
    //    {
    //        Debug.Log("hit");
    //        CharacterDetected = true;
    //    }
    //}

    //void OnTriggerExit2D(Collider2D obj)
    //{
    //    if (obj.transform.name != "Player")
    //    {
    //        Debug.Log("out");
    //        CharacterDetected = false;
    //    }
    //}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("hit");
            CharacterDetected = true;
        }
    }

    //public void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("out");
    //        CharacterDetected = true;
    //    }
    //}
}
