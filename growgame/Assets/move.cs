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
    GetPoint Gp;
    Problem pro;
    ApplePrefab pref;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        Gp = GameObject.Find("PrintPoint").GetComponent<GetPoint>();
        pro = GameObject.Find("ProblemText").GetComponent<Problem>();
        pref = GameObject.Find("ApplePrefab").GetComponent<ApplePrefab>();
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
        target1 = GameObject.Find("apple1(Clone)");
        target2 = GameObject.Find("apple2(Clone)");
        target3 = GameObject.Find("apple3(Clone)");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if(pro.ans == 1)
        {
            if (collision.tag == "apple1")
            {
                pref.span = 10;
                count1++;
                Gp.AddPoint(10);
                AppleDestroy();
            }
            else if(collision.tag == "apple2" | collision.tag == "apple3")
            {
                Gp.AddPoint(-10);
            }
        }
        else if (pro.ans == 2)
        {
            if (collision.tag == "apple2")
            {
                pref.span = 10;
                count2++;
                Gp.AddPoint(10);
                AppleDestroy();
            }
            else if (collision.tag == "apple1" | collision.tag == "apple3")
            {
                Gp.AddPoint(-10);
            }
        }
        else if (pro.ans == 3)
        {
            if (collision.tag == "apple3")
            {
                pref.span = 10;
                count3++;
                Gp.AddPoint(10);
                AppleDestroy();
            }
            else if(collision.tag == "apple2" | collision.tag == "apple1")
            {
                Gp.AddPoint(-10);
            }
        }
    }

    public int Getcount()
    {
        return count1+count2+count3;
    }

    public void AppleDestroy()
    {
        Destroy(target1);
        Destroy(target2);
        Destroy(target3);
    }
}
