using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataShow : MonoBehaviour {
    public GameObject Box;
    public GameObject h, c, o, na, al, si, s, cl, ca, hg;
    private bool clickH, clickC, clickO, clickNa, clickAl, clickSi, clickS, clickCl, clickCa, clickHg;
    private int ClickStatus = 0;
    // Use this for initialization
    void Start () {
        Box.active = false;
        h.active = false;
        c.active = false;
        o.active = false; 
        na.active = false; 
        al.active = false; 
        si.active = false; 
        s.active = false; 
        cl.active = false;
        ca.active = false; 
        hg.active = false;
        clickH = false;
        clickC = false;
        clickO = false;
        clickNa = false;
        clickAl = false;
        clickSi = false;
        clickS = false;
        clickCl = false;
        clickCa = false;
        clickHg = false;
    }
	
	// Update is called once per frame
    void Update () {
    
        if (ClickStatus == 1)
        {
            Box.active = true;
            h.active = true;
            c.active = false;
            o.active = false;
            na.active = false;
            al.active = false;
            si.active = false;
            s.active = false;
            cl.active = false;
            ca.active = false;
            hg.active = false;
        }
        if(ClickStatus == 2)
        {
            Box.active = true;
            h.active = false;
            c.active = true;
            o.active = false;
            na.active = false;
            al.active = false;
            si.active = false;
            s.active = false;
            cl.active = false;
            ca.active = false;
            hg.active = false;
        }
        if(ClickStatus == 3)
        {
            Box.active = true;
            h.active = false;
            c.active = false;
            o.active = true;
            na.active = false;
            al.active = false;
            si.active = false;
            s.active = false;
            cl.active = false;
            ca.active = false;
            hg.active = false;
        }
        if(ClickStatus == 4)
        {
            Box.active = true;
            h.active = false;
            c.active = false;
            o.active = false;
            na.active = true;
            al.active = false;
            si.active = false;
            s.active = false;
            cl.active = false;
            ca.active = false;
            hg.active = false;
        }
        if(ClickStatus == 5)
        {
            Box.active = true;
            h.active = false;
            c.active = false;
            o.active = false;
            na.active = false;
            al.active = true;
            si.active = false;
            s.active = false;
            cl.active = false;
            ca.active = false;
            hg.active = false;
        }
        if(ClickStatus == 6)
        {
            Box.active = true;
            h.active = false;
            c.active = false;
            o.active = false;
            na.active = false;
            al.active = false;
            si.active = true;
            s.active = false;
            cl.active = false;
            ca.active = false;
            hg.active = false;
        }
        if(ClickStatus == 7)
        {
            Box.active = true;
            h.active = false;
            c.active = false;
            o.active = false;
            na.active = false;
            al.active = false;
            si.active = false;
            s.active = true;
            cl.active = false;
            ca.active = false;
            hg.active = false;
        }
        if(ClickStatus == 8)
        {
            Box.active = true;
            h.active = false;
            c.active = false;
            o.active = false;
            na.active = false;
            al.active = false;
            si.active = false;
            s.active = false;
            cl.active = true;
            ca.active = false;
            hg.active = false;
        }
        if(ClickStatus == 9)
        {
            Box.active = true;
            h.active = false;
            c.active = false;
            o.active = false;
            na.active = false;
            al.active = false;
            si.active = false;
            s.active = false;
            cl.active = false;
            ca.active = true;
            hg.active = false;
        }
        if(ClickStatus == 10)
        {
            Box.active = true;
            h.active = false;
            c.active = false;
            o.active = false;
            na.active = false;
            al.active = false;
            si.active = false;
            s.active = false;
            cl.active = false;
            ca.active = false;
            hg.active = true;
        }
    }

    public void SelectH()
    {
        if (clickH == false)
        {
            clickH = true;
            ClickStatus = 1;
        }
        else
        {
            clickH = false;
            ClickStatus = 0;
        }
    }

    public void SelectC()
    {
        if (clickC == false)
        {
            clickC = true;
            ClickStatus = 2;
        }
        else
        {
            clickC = false;
            ClickStatus = 0;
        }
    }

    public void SelectO()
    {
        if (clickO == false)
        {
            clickO = true;
            ClickStatus = 3;
        }
        else
        {
            clickO = false;
            ClickStatus = 0;
        }
    }

    public void SelectNa()
    {
        if (clickNa == false)
        {
            clickNa = true;
            ClickStatus = 4;
        }
        else
        {
            clickNa = false;
            ClickStatus = 0;
        }
    }

    public void SelectAl()
    {
        if (clickAl == false)
        {
            clickAl = true;
            ClickStatus = 5;
        }
        else
        {
            clickAl = false;
            ClickStatus = 0;
        }
    }

    public void SelectSi()
    {
        if (clickSi == false)
        {
            clickSi = true;
            ClickStatus = 6;
        }
        else
        {
            clickSi = false;
            ClickStatus = 0;
        }
    }

    public void SelectS()
    {
        if (clickS == false)
        {
            clickS = true;
            ClickStatus = 7;
        }
        else
        {
            clickS = false;
            ClickStatus = 0;
        }
    }

    public void SelectCl()
    {
        if (clickCl == false)
        {
            clickCl = true;
            ClickStatus = 8;
        }
        else
        {
            clickCl = false;
            ClickStatus = 0;
        }
    }

    public void SelectCa()
    {
        if (clickCa == false)
        {
            clickCa = true;
            ClickStatus = 9;
        }
        else
        {
            clickCa = false;
            ClickStatus = 0;
        }
    }

    public void SelectHg()
    {
        if (clickHg == false)
        {
            clickHg = true;
            ClickStatus = 10;
        }
        else
        {
            clickHg = false;
            ClickStatus = 0;
        }
    }

}
