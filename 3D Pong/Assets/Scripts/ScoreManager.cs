using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int playerScore1;
    public int playerScore2;
    public int playerScore3;
    public int playerScore4;

    public int maxScore;

    public void AddScorePlayer1(int increment)
    {
        playerScore1 += increment;

        if(playerScore1 >= maxScore)
        {
            GameOver();
        }
    }

    public void AddScorePlayer2(int increment)
    {
        playerScore2 += increment;

        if (playerScore2 >= maxScore)
        {
            GameOver();
        }
    }

    public void AddScorePlayer3(int increment)
    {
        playerScore3 += increment;

        if (playerScore3 >= maxScore)
        {
            GameOver();
        }
    }

    public void AddScorePlayer4(int increment)
    {
        playerScore4 += increment;

        if (playerScore4 >= maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
