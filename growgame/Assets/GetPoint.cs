using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPoint : MonoBehaviour {

    public static GetPoint instance;
    public Text PrintpPoint;

    public static int point = 50;

    public static int waterpoint = 50;



    void Awake(){

}

    // Use this for initialization
    void Start () { 

        PrintpPoint = GameObject.Find("Point").GetComponent<Text>();
        PrintpPoint.text = "점수 :" + waterpoint; //여기가 point라서 초기값이 50으로나오고 미니게임상 점수를 얻어오면 줄력이 sunpoint로 바뀌어서 왔다갔다하는거
    }

    public void WaterAddPoint(int num)
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