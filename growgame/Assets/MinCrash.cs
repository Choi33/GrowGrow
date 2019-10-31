using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinCrash : MonoBehaviour {

    MinGetPoint Mingetp;

    Rigidbody2D rb;
    public GameObject target1;

    int non_count = 0;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        Mingetp = GameObject.Find("PrintPoint2").GetComponent<MinGetPoint>();

        target1 = GameObject.Find("nonapple(Clone)");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "apple")
        {
            Mingetp.SunAddPoint(6);
            AppleDestroy();
        }
    }

    public void AppleDestroy()
    {
        Destroy(target1);
    }

}
