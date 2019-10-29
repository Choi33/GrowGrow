using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePrefab : MonoBehaviour {

    public GameObject[] applePrefab;
    public float span = 1.5f;
    float delta = 0;

    // Update is called once per frame
    void Update () {
        this.delta += Time.deltaTime;
        if (this.span == 7)
        {
            Debug.Log("지연");
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(applePrefab[Random.Range(0, applePrefab.Length)]) as GameObject;
                float px = Random.Range(-6, 2);
                go.transform.position = new Vector3(px, 7, 0);
                Debug.Log("새거나온당");
                this.span = 1.5f;
            }
        }
        else if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(applePrefab[Random.Range(0, applePrefab.Length)]) as GameObject;
            float px = Random.Range(-6, 2);
            go.transform.position = new Vector3(px, 7, 0);
            Debug.Log("기본");
        }
        
    }

}