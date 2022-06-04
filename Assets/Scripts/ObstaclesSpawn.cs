using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawn : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject[] obstacles;
    public float spawnTime = 1.0f;
    public float nextSpawn = 0.0f;

    void Update()
    {
        if(Time.time > nextSpawn){
            nextSpawn = Time.time + spawnTime;
            GameObject obstacleClone = Instantiate(obstacles[Random.Range(0, obstacles.Length)], transform.position, transform.rotation) as GameObject;
            Destroy(obstacleClone, 5);
        }

    }
}
