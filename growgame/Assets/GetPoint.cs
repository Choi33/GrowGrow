using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoint : MonoBehaviour {

    public static GetPoint instance;
    public Text PrintpPoint;
    public static int waterpoint = 50;
 
    

    void Awake()
    {
    }

    // Use this for initialization
    void Start () { 

        PrintpPoint = GameObject.Find("Point").GetComponent<Text>();
        PrintpPoint.text = "점수 :" + waterpoint;
    }

    public void AddPoint(int num)
    {
        waterpoint = waterpoint + num;
        if(waterpoint < 0)
        {
            waterpoint = 0;
        }
        PrintpPoint.text = "점수 : " + waterpoint;
    }
	
	// Update is called once per frame
	void Update () { 
    }        
}