﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePrefab : MonoBehaviour {

    public GameObject[] applePrefab;
    float span = 1.0f;
    float delta = 0;
    public int count = 0;

    // Update is called once per frame
    void Update () {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(applePrefab[Random.Range(0, applePrefab.Length)]) as GameObject;
            int px = Random.Range(-6, 2);
            go.transform.position = new Vector3(px, 7, 0);;
        }
	}

}