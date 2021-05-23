using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScrene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LoadMenu());
    }
    // Waiting for 3 sec
    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}
