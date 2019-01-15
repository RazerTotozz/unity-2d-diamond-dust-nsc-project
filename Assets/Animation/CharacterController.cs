using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public int defL = 30;
    public int atkL = 20;
    public float maxSpeed = 3f;
    public bool facingLeft = true;
    public float rotation = 0f;
    public Rigidbody2D rigid;
    public GameObject character;
    //private Vector3 offset;
    public Transform t;
    public float jumpForce = 700f;
    public bool isGrounded = false;
    public Transform GroundCheck;

    public Animator anim;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        float maxHP = defL * 100;
    }
	// Update is called once per frame
	void FixedUpdate () {
        float move = Input.GetAxis("Horizontal"); 
        anim.SetFloat("Speed", Mathf.Abs(move));
            t.eulerAngles = new Vector3(t.eulerAngles.x, t.eulerAngles.y, rotation);
        rigid.velocity = new Vector2(move * maxSpeed, rigid.velocity.y);
        if (move < 0 && !facingLeft)
        {
            Flip();
        }else if(move > 0 && facingLeft)
            Flip();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigid.AddForce(new Vector2(0, jumpForce));
        }
    }
    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
