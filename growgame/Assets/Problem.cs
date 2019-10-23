using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class Problem : MonoBehaviour {


     public String[,] que = { 
        { "1", "오늘날 컴퓨터가 따르는 (  )는 실행하고자 하는 프로그램이 메모리 위에 전부 올라와야하는 구조로 하드웨어는 그대로 둔 채 작업을 이한 프로그램만 교체하여 메모리에 올린다. " +
                "\n\n1. 폰노이만   2. 양자구조   3. 계층구조" }, 
        { "2", "문제2" } }; 
 

    public Text queText;


    // Use this for initialization
    void Start () {
          
	}
	
	// Update is called once per frame
	void Update () {

        queText.GetComponent<Text>().text = que[0, 1];
	}
}
