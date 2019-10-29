using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class SceChMin : MonoBehaviour {

    GameObject Loding;
    // Use this for initialization

    public void OnClick()
    {
        GetComponent<AudioSource>().Play();
        Loding = GameObject.Find("LodingFade");
        Loding.transform.Translate(-1200, 0, 0);
        StartCoroutine(NextScene());
    }


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MinGame");
        // Destroy(this.gameObject);
    }
}
