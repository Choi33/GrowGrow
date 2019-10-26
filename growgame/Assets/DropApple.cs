using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropApple : MonoBehaviour {

    GameObject soil_shoot;

    public int count = 0;

	// Use this for initialization
	void Start () {
        this.soil_shoot = GameObject.Find("soil_shoot");
	}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.05f, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}