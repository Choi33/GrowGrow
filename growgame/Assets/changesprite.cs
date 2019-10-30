using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changesprite : MonoBehaviour {

    public static Sprite nextSprite1;
    public static Sprite nextSprite2;

    // Use this for initialization
    void Start () {
		
	}
	
    void changeImg()
    {
        if (MinGetPoint.sunpoint >= 150 && GetPoint.waterpoint >= 250)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite1;
        }
        if (MinGetPoint.sunpoint >= 250 && GetPoint.waterpoint >= 450)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite2;
        }

    }
	// Update is called once per frame
	void Update () {
        changeImg();
	}
}
