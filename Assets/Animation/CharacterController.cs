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

    public bool canClimb = false;

    public Vector2 force = Vector2.up;

    public Animator anim;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        float maxHP = defL * 100;
        character = GameObject.FindGameObjectWithTag("Player");
    }
	// Update is called once per frame
	void FixedUpdate () {

        //move left right
        float move = Input.GetAxis("Horizontal"); 

        //move animator
        anim.SetFloat("Speed", Mathf.Abs(move));

        //ไม่ปลิว ไม่ล้ม
        t.eulerAngles = new Vector3(t.eulerAngles.x, t.eulerAngles.y, rotation);

        //Gravity
        rigid.velocity = new Vector2(move * maxSpeed, rigid.velocity.y);

        //Filp
        if (move < 0 && !facingLeft)
        {
            Flip();
        }else if(move > 0 && facingLeft)
            Flip();

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigid.AddForce(new Vector2(0, jumpForce));
        }


        //if (canClimb == true)
        //    Debug.Log("canClimb");
        //else Debug.Log("can't climb");
        //Climb
        if (canClimb == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                character.transform.Translate(new Vector2(0f, 1f) * Time.deltaTime * maxSpeed);
                //GetComponent<Collider2D>().attachedRigidbody.AddForce(force);
                rigid.gravityScale = 0;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                character.transform.Translate(new Vector2(0f, -1f) * Time.deltaTime * maxSpeed);
                rigid.gravityScale = 0;
            }
            else rigid.gravityScale = 10;
        }

        Physics2D.IgnoreLayerCollision(0,8);

    }


    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "ladder")
    //    {
    //        Debug.Log("hitladder");
    //        canClimb = true;
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ladder")
        {
            Debug.Log("hitladder");
            canClimb = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Ladder")
        {
            Debug.Log("Outladder");
            canClimb = true;
        }
    }
}
