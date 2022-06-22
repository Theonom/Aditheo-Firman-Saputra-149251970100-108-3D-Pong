using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;

    private Rigidbody rig;

    public Collider gawang1, gawang2, gawang3, gawang4;
    public BallManager ballManager;
    public ScoreManager scoreManager;

    public void Start()
    {
        rig = GetComponent<Rigidbody>();
        BallMotion();
    }

    public void BallMotion()
    {
        if(gameObject.transform.position.x < 0 && gameObject.transform.position.z <0)
        {
            rig.velocity = new Vector3(speed.x, speed.y, speed.z);
        }
        if (gameObject.transform.position.x > 0 && gameObject.transform.position.z < 0)
        {
            rig.velocity = new Vector3(-speed.x, speed.y, speed.z);
        }
        if (gameObject.transform.position.x > 0 && gameObject.transform.position.z > 0)
        {
            rig.velocity = new Vector3(-speed.x, speed.y, -speed.z);
        }
        if (gameObject.transform.position.x < 0 && gameObject.transform.position.z > 0)
        {
            rig.velocity = new Vector3(speed.x, speed.y, -speed.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == gawang1)
        {
            scoreManager.AddScorePlayer1(1);
            ballManager.RemoveBall(gameObject);
        }
        if (other == gawang2)
        {
            scoreManager.AddScorePlayer2(1);
            ballManager.RemoveBall(gameObject);
        }
        if (other == gawang3)
        {
            scoreManager.AddScorePlayer3(1);
            ballManager.RemoveBall(gameObject);
        }
        if (other == gawang4)
        {
            scoreManager.AddScorePlayer4(1);
            ballManager.RemoveBall(gameObject);
        }
    }
}
