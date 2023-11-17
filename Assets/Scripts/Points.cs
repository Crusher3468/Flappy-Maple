using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Points : MonoBehaviour
{
    int score = 0;
    GameObject other;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Console.WriteLine("collision");

        if (collision.gameObject.CompareTag("Point"))
        {
            score++;
            print(score);
            Destroy(collision.gameObject);
        }
    }
}
