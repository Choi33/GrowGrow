using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GageUI : MonoBehaviour {

    GameObject Sungage;
    GameObject Watergage;

    public Text waterpoint;
    public Text sunpoint;
    public int suncount = 0;
    public int watercount = 0;

    int Water = 0;
    int Sun = 0;
    // Use this for initialization
    void Start () {
        this.Sungage = GameObject.Find("Sungage");
        this.Watergage = GameObject.Find("Watergage");

        waterpoint = GameObject.Find("WaterIcon_text").GetComponent<Text>();
        waterpoint.text = "x " + watercount;

        sunpoint = GameObject.Find("SunIcon_text").GetComponent<Text>();
        sunpoint.text = "x " + suncount;

    }
	void Update()
    {
        WaterIconCount();
        SunIconCount();
        Water = GetPoint.waterpoint- 50 - watercount * 100;
        Sun = MinGetPoint.sunpoint - suncount * 50;
        if (Water >= 100)
        {
            this.Sungage.GetComponent<Image>().fillAmount = 1.0f;
        }

        if (Sun >= 50)
        {
            this.Watergage.GetComponent<Image>().fillAmount = 1.0f;
        }

        this.Sungage.GetComponent<Image>().fillAmount = Sun / 50f;
        this.Watergage.GetComponent<Image>().fillAmount = Water / 100f;
    }

    public void WaterIconCount()
    {
        int temp = GetPoint.waterpoint;
        if (temp >= 150)
        {            
            watercount = 1;
        }
        if (temp >= 250)
        {
            watercount = 2;
        }

        if (temp >= 350)
        {
            watercount = 3;
        }

        if (temp >= 450)
        {
            watercount = 4;
        }
        waterpoint.text = "x " + watercount;
    }

    public void SunIconCount()
    {
        int temp2 = MinGetPoint.sunpoint;

        if (temp2 >= 50)
        {
            suncount = 1;
        }

        if (temp2 >= 100)
        {
            suncount = 2;
        }
        sunpoint.text = "x " + suncount;
    }
}