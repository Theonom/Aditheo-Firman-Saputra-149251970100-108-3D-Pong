using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int sumPlayer = 4;
    public int playerScore1, playerScore2, playerScore3, playerScore4;

    public GameObject gawang1, gawang2, gawang3, gawang4;
    public GameObject player1, player2, player3, player4;

    public GameObject gameOverUI;

    private bool isPlayer1 = true;
    private bool isPlayer2 = true;
    private bool isPlayer3 = true;
    private bool isPlayer4 = true;

    public string playerWinner;
    public int maxScore;

    private void Update()
    {
        GameOver();
    }

    public void AddScorePlayer1(int increment)
    {
        playerScore1 += increment;

        if(playerScore1 >= maxScore)
        {
            gawang1.GetComponent<Collider>().isTrigger = false;
            player1.SetActive(false);
            sumPlayer -= 1;
            isPlayer1 = false;
        }
    }

    public void AddScorePlayer2(int increment)
    {
        playerScore2 += increment;

        if (playerScore2 >= maxScore)
        {
            gawang2.GetComponent<Collider>().isTrigger = false;
            player2.SetActive(false);
            sumPlayer -= 1;
            isPlayer2 = false;
        }
    }

    public void AddScorePlayer3(int increment)
    {
        playerScore3 += increment;

        if (playerScore3 >= maxScore)
        {
            gawang3.GetComponent<Collider>().isTrigger = false;
            player3.SetActive(false);
            sumPlayer -= 1;
            isPlayer3 = false;
        }
    }

    public void AddScorePlayer4(int increment)
    {
        playerScore4 += increment;

        if (playerScore4 >= maxScore)
        {
            gawang4.GetComponent<Collider>().isTrigger = false;
            player4.SetActive(false);
            sumPlayer -= 1;
            isPlayer4 = false;
        }
    }

    public void GameOver()
    {
        if(sumPlayer == 1)
        {
            if (isPlayer1)
            {
                playerWinner = "PLAYER 1 WIN";
                gameOverUI.SetActive(true);
            }
            if (isPlayer2)
            {
                playerWinner = "PLAYER 2 WIN";
                gameOverUI.SetActive(true);
            }
            if (isPlayer3)
            {
                playerWinner = "PLAYER 3 WIN";
                gameOverUI.SetActive(true);
            }
            if (isPlayer4)
            {
                playerWinner = "PLAYER 4 WIN";
                gameOverUI.SetActive(true);
            }
        }
    }
}
