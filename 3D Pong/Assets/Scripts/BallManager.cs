using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public int maxBall;
    public int spawnInterval;
    public GameObject ballTemplate;
    public List<GameObject> spawnList;
    private List<GameObject> ballList;

    private float timer;

    private void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > spawnInterval)
        {
            SpawnBall();
            timer -= spawnInterval;
        }
    }
    
    public void SpawnBall()
    {
        if(ballList.Count >= maxBall)
        {
            return;
        }

        int spawnIndex = Random.Range(0, spawnList.Count);
        GameObject ball = Instantiate(ballTemplate, spawnList[spawnIndex].gameObject.transform.position, Quaternion.identity);
        ball.SetActive(true);

        ballList.Add(ball);
    }

    public void RemoveBall(GameObject ball)
    {
        ballList.Remove(ball);
        Destroy(ball);
    }
}
