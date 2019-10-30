using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mindropApple : MonoBehaviour {

    GameObject soil_shoot;
    float speed;
    public int count = 0;
    // Use this for initialization
    void Start()
    {
        this.soil_shoot = GameObject.Find("soil_shoot");
        speed = Random.Range(0.06f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
