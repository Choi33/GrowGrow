using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {
  //  bool buttonPause;

    public void ReturnMain()
    {

        Debug.Log("홈");
        SceneManager.LoadScene("Main");
        //Destroy(this.gameObject);
    }


    public void Pause()
    {
        /*
        if (buttonPause == false)
        {
            this.buttonPause = true;
        }
        else
            this.buttonPause=false;
            */
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (this.buttonPause == true)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
            */
	}

}
