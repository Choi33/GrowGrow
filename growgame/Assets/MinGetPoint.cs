using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MinGetPoint : MonoBehaviour {

    public static MinGetPoint instance;
    public Text PrintpPoint2;

    public float LimitTime;
    public Text text_Timer;

    public static int sunpoint = 0;
    int point;
    // Use this for initialization
    void Start () {

        PrintpPoint2 = GameObject.Find("Point").GetComponent<Text>();
        PrintpPoint2.text = "점수 :" + point;

    }

    public void SunAddPoint(int num1)
    {
        point += num1;
        PrintpPoint2.text = "점수 : " + point;
    }

    // Update is called once per frame
    void Update () {
        LimitTime -= Time.deltaTime;
        text_Timer.text = "시간 : " + Mathf.Round(LimitTime);

        if (LimitTime <= 0)
        {
            sunpoint += point;
            SceneManager.LoadScene("Main");
        }
    }
}
