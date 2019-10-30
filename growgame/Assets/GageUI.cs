using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GageUI : MonoBehaviour {

    GameObject Sungage;
    GameObject Watergage;
	// Use this for initialization
	void Start () {
        this.Sungage = GameObject.Find("Sungage");
        this.Watergage = GameObject.Find("Watergage");
    }
	void Update()
    {
        this.Sungage.GetComponent<Image>().fillAmount = MinGetPoint.sunpoint / 50f;
        this.Watergage.GetComponent<Image>().fillAmount = (GetPoint.waterpoint-50) / 100f;
    }
}
