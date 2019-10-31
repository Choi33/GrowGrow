using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class SceneChange : MonoBehaviour {

    GameObject Loading;
    public void OnClick()
    {
        GetComponent<AudioSource>().Play();
        Loading = GameObject.Find("LoadingFade");
        Loading.transform.Translate(-1280, 0, 0);
        StartCoroutine(NextScene());
    }
    
    void Start () {
		
	}
	
	void Update () {
	}
    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game");
    }
}
