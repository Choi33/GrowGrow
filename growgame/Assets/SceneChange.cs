﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class SceneChange : MonoBehaviour {

    GameObject Loding;
    public void OnClick()
    {
        //SM.Play(Clip);
        GetComponent<AudioSource>().Play();
        Loding = GameObject.Find("LodingFade");
        Loding.transform.Translate(-1200, 0, 0);
        StartCoroutine(NextScene());
        //SceneManager.LoadScene("Loading");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetMouseButton(0))
        {
            SM.Play(Clip);
            SceneManager.LoadScene("Loading");
        }
        */
	}
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Game");
    }
}
