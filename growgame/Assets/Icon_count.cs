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

   /*
    public void SunCount(int num)
    {

        if ((GetPoint.point>=60))
        {
            sunpoint.text = "x " + suncount+1;
        }

        if ((GetPoint.point >= 80))
        {
            sunpoint.text = "x " + suncount + 2;
        }

    }

    public void WaterCount(int num)
    {
        if ((GetPoint.point>=70))
        {
            waterpoint.text = "x " + watercount+1;
        }
    }
    */
    public void IconCount()
    {
        int temp = GetPoint.point;
        if (temp >= 60 && temp <= 70) 
        {
            sunpoint.text = "x " + suncount + 1;
        }
        if(temp >= 71 && temp <= 80) {
            waterpoint.text = "x " + watercount + 1;
        }          
    }

    // Update is called once per frame
    void Update () {
        IconCount();
        //SunCount(suncount);
        //WaterCount(watercount);
	}

}
