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
    private float minY;
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
        GameObject go = Instantiate(pipe);

        float random = Random.Range(minY, maxY);

        go.transform.position = new Vector3(xPos, random);
    }
}
