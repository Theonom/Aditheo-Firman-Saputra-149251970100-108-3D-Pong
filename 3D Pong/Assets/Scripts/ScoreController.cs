using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text skorPlayer1, skorPlayer2, skorPlayer3, skorPlayer4;

    public ScoreManager manager;

    private void Update()
    {
        skorPlayer1.text = manager.playerScore1.ToString();
        skorPlayer2.text = manager.playerScore2.ToString();
        skorPlayer3.text = manager.playerScore3.ToString();
        skorPlayer4.text = manager.playerScore4.ToString();
    }

}
