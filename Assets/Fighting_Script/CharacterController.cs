using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour {

    public int countO;
    public int countSi;
    public int countC;
    public int countMoney;
    public Text countCText;
    public Text countSiText;
    public Text countOText;
    public Text countMoneyText;

    public int defL = 30;
    public int atkL = 20;
    public int MaxHp = 300;
    public int currentHP;
    public Slider HPbar;
    public bool isDead = false;
    public bool isDamage = false;

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

    public GameObject summaryBox;

    public Animator anim;

    public GameObject lapis;

    //MonsterWalk monWalk = gameObject.GetComponent<MonsterWalk>();
    public GameObject monster;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        character = GameObject.FindGameObjectWithTag("Player");
        //monWalk = gameObject.GetComponent<MonsterWalk>();

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
        //Physics2D.IgnoreLayerCollision(0, 9);

        //Atk
        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("isAtk", true);
        } else anim.SetBool("isAtk", false);

        //Destroy enemy
        //if (monWalk.isTouch)
        //monster.SetActive(false);

        //Skill
        if (Input.GetKey(KeyCode.Q))
        {
            lapis.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            lapis.SetActive(true);
        }
        else lapis.SetActive(false);
    }

    private void Update()
    {
        SetCountText();
    }

    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ladder")
        {
            //Debug.Log("hitladder");
            canClimb = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Ladder")
        {
            //Debug.Log("Outladder");
            canClimb = true;
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Crystal")
        {
            Debug.Log("hit");
            countO += Random.Range(0, 7);
            countC += Random.Range(0, 5);
            countSi += Random.Range(0, 2);

        }

        if (obj.gameObject.tag == "Chest")
        {
            Debug.Log("hit");
            countO += Random.Range(0, 10);
            countC += Random.Range(0, 7);
            countSi += Random.Range(0, 5);
            countMoney += Random.Range(200, 2000);
            summaryBox.SetActive(true);
            Destroy(character,0.2f);
        }
        if (obj.gameObject.tag == "fall")
        {
            Debug.Log("hit");
            //countO += Random.Range(0, 10);
            //countC += Random.Range(0, 7);
            //countSi += Random.Range(0, 5);
            //countMoney += Random.Range(200, 2000);
            summaryBox.SetActive(true);
            Destroy(character, 0.2f);
        }
    }

    void SetCountText()
    {
        countCText.text = countC.ToString();
        countOText.text = countO.ToString();
        countSiText.text = countSi.ToString();
        countMoneyText.text = countMoney.ToString();
        PlayerPrefs.SetInt("countC", countC);
        PlayerPrefs.SetInt("countO", countO);
        PlayerPrefs.SetInt("countSi", countSi);
        PlayerPrefs.SetInt("countMoney", countMoney);
    }

}
