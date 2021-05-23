using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOptions : MonoBehaviour
{
    public void NewGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(2);
    }

    public void ResetPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
