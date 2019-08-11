using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNumber : MonoBehaviour {
    public Text textH, textC, textO, textNa, textAl, textSi, textS, textCl, textCa, textHg, textMoney;
    // Use this for initialization
    void Start () {
        textH.text = PlayerPrefs.GetInt("countH").ToString();
        textC.text = PlayerPrefs.GetInt("countC").ToString();
        textO.text = PlayerPrefs.GetInt("countO").ToString();
        textNa.text = PlayerPrefs.GetInt("countNa").ToString();
        textAl.text = PlayerPrefs.GetInt("countAl").ToString();
        textSi.text = PlayerPrefs.GetInt("countSi").ToString();
        textS.text = PlayerPrefs.GetInt("countS").ToString();
        textCl.text = PlayerPrefs.GetInt("countCl").ToString();
        textCa.text = PlayerPrefs.GetInt("countCa").ToString();
        textHg.text = PlayerPrefs.GetInt("countHg").ToString();
        textMoney.text = PlayerPrefs.GetInt("countMoney").ToString();
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
