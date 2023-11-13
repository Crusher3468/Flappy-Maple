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
    private float maxY;
    [SerializeField]
    private float gapSize;
    [SerializeField]
    private float xPos;


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
        float spawnPosition1 = (Random.value * maxY) + 7;
        float spawnPosition2 = spawnPosition1 - gapSize;

        GameObject pipe1 = Instantiate(pipe);
        GameObject pipe2 = Instantiate(pipe);

        pipe1.transform.position = new Vector3(xPos, spawnPosition1, 0);
        pipe2.transform.position = new Vector3(xPos, spawnPosition2, 0);
    }
}
