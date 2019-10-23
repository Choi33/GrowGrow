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
        if (!instance) //정적으로 자신을 체크합니다.
            instance = this; //정적으로 자신을 저장합니다.
    }

    // Use this for initialization
    void Start () {

        PrintpPoint = GameObject.Find("Point").GetComponent<Text>();
        PrintpPoint.text = "점수 : 50";
    }

    public void AddPoint(int num)
    {
        point += num;
        PrintpPoint.text = "점수 : " + point;
    }
	
	// Update is called once per frame
	void Update () {


    }
}
