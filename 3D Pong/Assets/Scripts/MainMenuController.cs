using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Play Scene");
    }

    public void HowToPlayGame()
    {
        SceneManager.LoadScene("How To Play Scene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
