using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Movement : MonoBehaviour
{
    private Vector3 force;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began) 
            {
                print("Tap");
                Vector3 direction = Vector2.zero;
                rb.AddForce(Vector2.up * 8, ForceMode2D.Impulse);
            }
        }

    }
}
