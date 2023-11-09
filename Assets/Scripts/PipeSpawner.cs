using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject pipe;
    [SerializeField]
    private float spawnTime;
    [SerializeField]
    private Vector2 spawnPosition1;
    [SerializeField]
    private Vector2 spawnPosition2;


    private float spawnTimer;

    void Start()
    {
        spawnTimer = spawnTime;
    }

   
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if(spawnTimer <= 0)
        {
            SpawnPipe();
            spawnTimer = spawnTime;
        }
    }

    void SpawnPipe()
    {
        GameObject pipe1 = Instantiate(pipe);
        GameObject pipe2 = Instantiate(pipe);

        pipe1.transform.position = spawnPosition1;
        pipe2.transform.position = spawnPosition2;
    }
}
