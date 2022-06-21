using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxBall;
    public Vector3 ballAreaMin;
    public Vector3 ballAreaMax;
    public int spawnInterval;

    public List<GameObject> ballTemplateList;
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
            GenerateRandomBall();
            timer -= spawnInterval;
        }
    }

    public void GenerateRandomBall()
    {
        GenerateRandomBall(new Vector3(Random.Range(ballAreaMin.x, ballAreaMax.x), Random.Range(ballAreaMin.y, ballAreaMax.y), Random.Range(ballAreaMin.z, ballAreaMax.z)));
    }

    public void GenerateRandomBall(Vector3 position)
    {
        if (ballList.Count >= maxBall)
        {
            return;
        }

        if(position.x < ballAreaMin.x ||
            position.x > ballAreaMax.x ||
            position.y < ballAreaMin.y ||
            position.y > ballAreaMax.y ||
            position.z < ballAreaMin.z ||
            position.z > ballAreaMax.z )
        {
            return;
        }

        int randomIndex = Random.Range(0, ballTemplateList.Count);
        GameObject ball = Instantiate(ballTemplateList[randomIndex], new Vector3(position.x, position.y, ballTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        ball.SetActive(true);

        ballList.Add(ball);
    }
}
