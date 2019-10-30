using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinGetPoint : MonoBehaviour {

    public static MinGetPoint instance;
    public Text PrintpPoint2;

    public static int sunpoint = 0;

    // Use this for initialization
    void Start () {

        PrintpPoint2 = GameObject.Find("Point").GetComponent<Text>();
        PrintpPoint2.text = "점수 :" + sunpoint;

    }

    public void SunAddPoint(int num1)
    {

        sunpoint = sunpoint + num1;
        Debug.Log("점수올라감" + num1);
        if (sunpoint < 0)
        {
            sunpoint = 0;
        }

        PrintpPoint2.text = "점수 : " + sunpoint;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
