﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoiStauts : MonoBehaviour {

    public static int change_s = 0;
    public static SoiStauts instance;

    // Use this for initialization
    void Start () {
		
	}
	
    public void change()
    {
        int temp;
        if (GetPoint.waterpoint >= 50 && MinGetPoint.sunpoint >= 0)
        {
            temp = change_s;
        }
        if (GetPoint.waterpoint >= 250 && MinGetPoint.sunpoint >= 100)
        {
            change_s = 1;
            temp = change_s;
        }

        if (GetPoint.waterpoint >= 450 && MinGetPoint.sunpoint >= 200)
        {
            change_s = 2;
            temp = change_s;
        }
    }
	// Update is called once per frame
	void Update () {

        change();
	}
}