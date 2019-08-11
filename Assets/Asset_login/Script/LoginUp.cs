using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUp : MonoBehaviour {

    public static bool setLogin;
    public Transform showLogin;
    public Transform hideLogin;
    public GameObject loginBox;
    public GameObject Startbtn;

    // Use this for initialization
    void Start () {
        setLogin = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (setLogin == true)
        {
            Debug.Log("Click");
            loginBox.transform.position = Vector3.Lerp(loginBox.transform.position, showLogin.position, Time.deltaTime * 5);
        }
        if (setLogin == false)
        {
            Debug.Log("Can't Click");
            loginBox.transform.position = Vector3.Lerp(loginBox.transform.position, hideLogin.position, Time.deltaTime * 5);
        }
        if(loginBox.transform.position.x == 0){
            Startbtn.SetActive(false);
        }
    }

    public void loginn()
    {

        if (setLogin == false)
        {
            setLogin = true;
        }
        else
        {
            setLogin = false;

        }

    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour
{
    public static bool setsetskill;
    public Transform showset;
    public Transform hideset;
    public GameObject settingg;
    // Use this for initialization
    void Start()
    {
        setsetskill = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (setsetskill == true)
        {
            //   Debug.Log("buttonn");
            settingg.transform.position = Vector3.Lerp(settingg.transform.position, showset.position, Time.deltaTime * 5);
        }
        if (setsetskill == false)
        {
            //  Debug.Log("cant press buttonn");
            settingg.transform.position = Vector3.Lerp(settingg.transform.position, hideset.position, Time.deltaTime * 5);
        }
    }
    public void skillskilll()
    {

        if (setsetskill == false)
        {
            setsetskill = true;
        }
        else
        {
            setsetskill = false;
        }

    }
}*/
