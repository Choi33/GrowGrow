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
        if (GetPoint.point >= 250 && GetPoint.point < 300)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite1;
        }
        if (GetPoint.point >=300)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite2;
        }

    }
	// Update is called once per frame
	void Update () {
        changeImg();
	}
}
