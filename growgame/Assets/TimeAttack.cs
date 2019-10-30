using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeAttack : MonoBehaviour {

    public float LimitTime;
    public Text text_Timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        LimitTime -= Time.deltaTime;
        text_Timer.text = "시간 : " + Mathf.Round(LimitTime);

        if(LimitTime<=0)
        {
            SceneManager.LoadScene("Main");
        }
	}
}
