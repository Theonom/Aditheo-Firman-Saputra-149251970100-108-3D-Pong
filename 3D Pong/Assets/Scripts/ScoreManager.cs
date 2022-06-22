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

    public GameObject gawang1, gawang2, gawang3, gawang4;
    public GameObject player1, player2, player3, player4;

    public int maxScore;

    public void AddScorePlayer1(int increment)
    {
        playerScore1 += increment;

        if(playerScore1 >= maxScore)
        {
            gawang1.GetComponent<Collider>().isTrigger = false;
            player1.SetActive(false);
        }
    }

    public void AddScorePlayer2(int increment)
    {
        playerScore2 += increment;

        if (playerScore2 >= maxScore)
        {
            gawang2.GetComponent<Collider>().isTrigger = false;
            player2.SetActive(false);
        }
    }

    public void AddScorePlayer3(int increment)
    {
        playerScore3 += increment;

        if (playerScore3 >= maxScore)
        {
            gawang3.GetComponent<Collider>().isTrigger = false;
            player3.SetActive(false);
        }
    }

    public void AddScorePlayer4(int increment)
    {
        playerScore4 += increment;

        if (playerScore4 >= maxScore)
        {
            gawang4.GetComponent<Collider>().isTrigger = false;
            player4.SetActive(false);
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Menu Scene");
    }
}
