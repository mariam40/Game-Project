using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject[] collect;

    private float ObstaclesSpawnZ = 12.0f;
    private float SpawnRangeX = 16.0f;
    private float CollectRange = 5.0f;
    private float SpawnY = 0.75f;

    private float collectSpawnTime = 5.0f;
    private float obstacleSpawnTime = 1.0f;
    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, obstacleSpawnTime);
        InvokeRepeating("SpawnCollect", startDelay, collectSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        float randomX = Random.Range(-SpawnRangeX, SpawnRangeX);
        int randomIndex = Random.Range(0, obstacles.Length);

        Vector3 spawnPos = new Vector3(randomX, SpawnY, ObstaclesSpawnZ);

        Instantiate(obstacles[randomIndex], spawnPos, obstacles[randomIndex].gameObject.transform.rotation);
    }

    void SpawnCollect()
    {
        float randomX = Random.Range(-SpawnRangeX, SpawnRangeX);
        int randomIndex = Random.Range(0, collect.Length);

        Vector3 spawnPos = new Vector3(randomX, SpawnY, CollectRange);

        Instantiate(collect[randomIndex], spawnPos, collect[randomIndex].gameObject.transform.rotation);
    }
}
