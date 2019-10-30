using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinApple : MonoBehaviour {

    public GameObject minapplePrefab;

    float span = 0.8f;
    float delta = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update()
    {
        
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject ap = Instantiate(minapplePrefab) as GameObject;
            float px = Random.Range(-6f, 2f);
            ap.transform.position = new Vector3(px, 7, 0);
        }

        
    }
}
