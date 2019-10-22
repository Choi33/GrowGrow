using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceneManager : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        StartCoroutine(NextScene());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game");
    }

}
