using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAllItemToZero : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey(KeyCode.Semicolon))
        {
            PlayerPrefs.SetInt("countH", 0);
            PlayerPrefs.SetInt("countC", 0);
            PlayerPrefs.SetInt("countO", 0);
            PlayerPrefs.SetInt("countNa", 0);
            PlayerPrefs.SetInt("countAl", 0);
            PlayerPrefs.SetInt("countSi", 0);
            PlayerPrefs.SetInt("countS", 0);
            PlayerPrefs.SetInt("countCl", 0);
            PlayerPrefs.SetInt("countCa", 0);
            PlayerPrefs.SetInt("countHg", 0);
            PlayerPrefs.SetInt("countMoney", 0);
        }

    }
}
