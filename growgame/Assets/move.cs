using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    float MoveSpeed = 0.02f;
    int KeyInputCheck = 0;
    int RightLeftDistinction = 0;//좌우판별
    Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            if (KeyInputCheck == 0)
            {
                KeyInputCheck = 1;
                RightLeftDistinction = 1;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (KeyInputCheck == 0)
            {
                KeyInputCheck = 1;
                RightLeftDistinction = -1;
            }
        }

        if (KeyInputCheck == 1)
        {
            KeyInputCheck = 0;
            rb.freezeRotation = true;
            InvokeRepeating("GrowMove", 0, 0.001f);
        }

    }

    void GrowMove()
    {
        transform.position += new Vector3(RightLeftDistinction * MoveSpeed, 0, 0);//이동
        //transform.position += new Vector3(-RightLeftDistinction *0.00001f *BoxRotation*(-30*BoxRotation+1)*1.059378145028868f, 0, 0);

    }

}
