using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoint : MonoBehaviour {

    public static GetPoint instance;
    public Text PrintpPoint;
    public int point = 50;
    int pointnum = 0;

    public move move;

    int getp1 = 0;
    int getp2 = 0;
    int getp3 = 0;

    void Awake()
    {
        move = GameObject.Find("soil_shoot").GetComponent<move>();
    }

    // Use this for initialization
    void Start () {

        PrintpPoint = GameObject.Find("Point").GetComponent<Text>();
        PrintpPoint.text = "점수 : 50";
    }

    public void AddPoint(int num)
    {
        PrintpPoint.text = "점수 : " + (50+num);
    }
	
	// Update is called once per frame
	void Update () {
        
        int pointemp = pointnum;
        pointnum = move.Getcount();

        int tempcount1 = getp1;
        getp1=move.count1;

        int tempcount2 = getp2;
        getp2 = move.count2;

        int tempcount3 = getp3;
        getp3 = move.count3;

        if (pointnum != pointemp)
        {
            if(getp1 != tempcount1)
            {
                AddPoint(getp1);
                Debug.Log("1번" + getp1);
            }

            if (getp2 != tempcount2)
            {
                AddPoint(getp2);
                Debug.Log("2번" + getp2);
            }

            if (getp3 != tempcount3)
            {
                AddPoint(getp3);
                Debug.Log("3번" + getp3);
            }
        }
        

    }
}
