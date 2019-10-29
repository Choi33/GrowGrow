using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMove : MonoBehaviour {

    Rigidbody2D rb;
    int RightLeftDistinction = 0;//좌우판별

    float MoveSpeed = 0.1f;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1 * MoveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1 * MoveSpeed, 0, 0);
        }

    }
}
