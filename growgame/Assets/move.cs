using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    float MoveSpeed = 0.1f;
    int KeyInputCheck = 0;
    int RightLeftDistinction = 0;//좌우판별
    Rigidbody2D rb;
    public int count1 = 0;
    public int count2 = 0;
    public int count3 = 0;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        PlayerPrefs.SetInt("Count", 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1*MoveSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1*MoveSpeed, 0, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "apple1")
        {
            count1++;
            PlayerPrefs.SetInt("Count", count1);
            //Debug.Log(count);
        }

        if (collision.tag == "apple2")
        {
            count2++;
            PlayerPrefs.SetInt("Count", count2);
            //Debug.Log(count);

        }

        if (collision.tag == "apple3")
        {
            count3++;
            PlayerPrefs.SetInt("Count", count3);
            //Debug.Log(count);

        }
    }

    public int Getcount()
    {
        return count1+count2+count3;
    }
}
