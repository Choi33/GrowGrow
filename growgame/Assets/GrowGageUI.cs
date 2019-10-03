using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrowGageUI : MonoBehaviour {
    GameObject GrowGage;
	// Use this for initialization
	void Start () {
        this.GrowGage = GameObject.Find("Growgage");
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.UpArrow))
        {
           this.GrowGage.GetComponent<Image>().fillAmount += 0.01f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.GrowGage.GetComponent<Image>().fillAmount -= 0.01f;
        }
    }
}
