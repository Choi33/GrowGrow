using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointup : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            GetPoint.waterpoint = 150;
            MinGetPoint.sunpoint = 50;
        }

        if (Input.GetMouseButton(1))
        {
            GetPoint.waterpoint = 350;
            MinGetPoint.sunpoint = 100;
        }


    }
}
