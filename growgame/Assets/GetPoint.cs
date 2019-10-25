using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoint : MonoBehaviour {

    public static GetPoint instance;
    public Text PrintpPoint;
    public int point = 50;
    

    void Awake()
    {
    }

    // Use this for initialization
    void Start () {

        PrintpPoint = GameObject.Find("Point").GetComponent<Text>();
        PrintpPoint.text = "점수 :" + point;
    }

    public void AddPoint(int num)
    {
        point = point + num;
        if(point < 0)
        {
            point = 0;
        }
        PrintpPoint.text = "점수 : " + point;
    }
	
	// Update is called once per frame
	void Update () {
    }        
}