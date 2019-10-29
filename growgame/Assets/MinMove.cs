using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMove : MonoBehaviour {

    Rigidbody2D rb;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;

    int RightLeftDistinction = 0;//좌우판별
    float MoveSpeed = 0.1f;


    void Start () {

        rb = GetComponent<Rigidbody2D>();

        target1 = GameObject.Find("apple1(Clone)");
        target2 = GameObject.Find("apple2(Clone)");
        target3 = GameObject.Find("apple3(Clone)");
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "apple1")
        {

        }
        if (collision.tag == "apple2")
        {

        }
        if (collision.tag == "apple3")
        {

        }
    }
}
