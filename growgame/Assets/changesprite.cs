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
        int c = SoilStauts.change_s;

        if (c==1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite1;
        }
        if (c==2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite2;
        }

    }
    // Update is called once per frame
    void Update () {
        changeImg();
	}
}
