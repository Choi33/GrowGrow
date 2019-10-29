using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Icon_count : MonoBehaviour {
   // public int count = 0;
    public Text waterpoint;
    public Text sunpoint;
    public int suncount = 0;
    public int watercount = 0;


   

    // Use this for initialization
    void Start () {
        waterpoint = GameObject.Find("WaterIcon_text").GetComponent<Text>();
        waterpoint.text = "x " + watercount;

        sunpoint = GameObject.Find("SunIcon_text").GetComponent<Text>();
        sunpoint.text = "x " + suncount;
    }

    public void WaterIconCount()
    {
        int temp = GetPoint.waterpoint;
        if (temp >= 100) 
        {
            waterpoint.text = "x " + watercount + 1;
        }
        if(temp >= 200) {
            waterpoint.text = "x " + watercount + 2;
        }          
    }

    public void SunIconCount()
    {
        int temp = GetPoint.sunpoint;
        if (temp >= 150)
        {
            sunpoint.text = "x" + sunpoint + 1;
        }
    }

    // Update is called once per frame
    void Update () {
        WaterIconCount();
        SunIconCount();
        //SunCount(suncount);
        //WaterCount(watercount);
    }

}
