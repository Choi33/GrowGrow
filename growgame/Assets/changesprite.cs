using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changesprite : MonoBehaviour {

    public Sprite nextSprite1;
    public Sprite nextSprite2;

    // Use this for initialization
    void Start () {
		
	}
	
    void changeImg()
    {
        if (GetPoint.waterpoint >= 250 && MinGetPoint.sunpoint >= 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite1;
        }
        if (GetPoint.waterpoint >=500 && MinGetPoint.sunpoint >= 300)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite2;
        }

    }
	// Update is called once per frame
	void Update () {
        changeImg();
	}
}
