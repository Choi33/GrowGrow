using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropApple : MonoBehaviour {

    GameObject soil_shoot;

	// Use this for initialization
	void Start () {
        this.soil_shoot = GameObject.Find("soil_shoot");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -0.05f, 0);

        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.soil_shoot.transform.position;
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.2f;

        if (d < r1 + r2)
        {
            Destroy(gameObject);
        }
	}
}
