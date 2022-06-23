using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text playerWin;
    public ScoreManager manager;

    private void Update()
    {
        playerWin.text = manager.playerWinner;
    }

    public void GoToReplay()
    {
        manager.gameOverUI.SetActive(false);
        SceneManager.LoadScene("Play Scene");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
