using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void FirstScene()
    {
        SceneManager.LoadScene(1);
    }

    public void SecondScene()
    {
        SceneManager.LoadScene(2);
    }

    public void ThirdScene()
    {
        SceneManager.LoadScene(3);
    }
    public void ExitGame()
    {
        Debug.Log("Exit Aplication");
        Application.Quit();

    }
}
