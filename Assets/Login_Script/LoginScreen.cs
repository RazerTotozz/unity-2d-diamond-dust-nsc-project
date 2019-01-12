using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class LoginScreen : MonoBehaviour
{
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    private String[] Lines;
    private string DecryptedPass;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void LoginButton()
    {
        bool UN = false;
        bool PW = false;
        if (Username != "")
        {
            if (System.IO.File.Exists(@"" + Username + ".txt"))
            {
                UN = true;
                Lines = System.IO.File.ReadAllLines(@"" + Username + ".txt");
            }
            else
            {
                Debug.LogWarning("Username Invalid");
            }
        }
        else
        {
            Debug.LogWarning("Username field empty");
        }
        if(Password !=""){
            if (System.IO.File.Exists(@"" + Username + ".txt")) {
                int i = 1;
                foreach (char c in Lines[1])
                {
                    i++;
                    char Decrypted = (char)(c / i);
                    DecryptedPass += Decrypted.ToString();
                }
                if(Password == DecryptedPass)
                {
                    PW = true;
                }
                else
                {
                    Debug.LogWarning("Password is False");
                }
            }
            else
            {
                Debug.LogWarning("Password is Invalid");
            }
        }
        else
        {
            Debug.LogWarning("Password Field Empty");
        }
        if (UN = true && PW == true)
        {
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
            print("Login Sucessful");
            Application.LoadLevel("Home");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (username.GetComponent<InputField>().isFocused)
            {
                password.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (Password != "" && Password != "")
            {
                LoginButton();
            }
        }
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
    }
}
