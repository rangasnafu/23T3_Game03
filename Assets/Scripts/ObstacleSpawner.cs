using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float maxXDistance = 5f;
    [SerializeField] private float maxSpawnDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {

        //start spawning enemies immediately, then repeat at random intervals
        float delay = Random.Range(0f, maxSpawnDelay);
        InvokeRepeating("SpawnObstacle", delay, maxSpawnDelay);
    }

    public void SpawnObstacle()
    {

        Vector3 spawnPosition = transform.position + new Vector3(Random.Range(-maxXDistance, maxXDistance), 0f, 0f);
        Quaternion spawnRotation = Quaternion.Euler(0f, 180f, 0f);
        Instantiate(obstaclePrefab, spawnPosition, spawnRotation);

    }
}
