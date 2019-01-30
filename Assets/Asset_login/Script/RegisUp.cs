using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisUp : MonoBehaviour {

    public static bool setRegis;
    public Transform showLogin;
    public Transform hideLogin;
    public GameObject loginBox;
    public Transform showRegis;
    public Transform hideRegis;
    public GameObject regisBox;

    // Use this for initialization
    void Start()
    {
        setRegis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (setRegis == true)
        {
            Debug.Log("Click r");
            loginBox.transform.position = Vector3.Lerp(loginBox.transform.position, hideLogin.position, Time.deltaTime * 0);
            loginBox.SetActive(false);
            regisBox.transform.position = Vector3.Lerp(loginBox.transform.position, showRegis.position, Time.deltaTime * 5);

        }
        if (setRegis == false)
        {
            //Debug.Log("Can't Click r");
            //loginBox.transform.position = Vector3.Lerp(loginBox.transform.position, showLogin.position, Time.deltaTime * 5);
            //regisBox.transform.position = Vector3.Lerp(loginBox.transform.position, hideRegis.position, Time.deltaTime * 5);
        }
    }

    public void regiss()
    {

        if (setRegis == false)
        {
            setRegis = true;
        }
        else
        {
            setRegis = false;

        }

    }
}
