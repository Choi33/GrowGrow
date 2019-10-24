using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class SceneChange : MonoBehaviour {

    //public AudioClip Clip;
    //SoundManager SM;
    //public GameObject Button;

    // Use this for initialization
    private void Awake()
    {
        //SM = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }

    public void OnClick()
    {
        //SM.Play(Clip);
        GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Loading");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetMouseButton(0))
        {
            SM.Play(Clip);
            SceneManager.LoadScene("Loading");
        }
        */
	}
}
