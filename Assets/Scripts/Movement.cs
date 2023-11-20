using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float speed;

    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector3.up * speed;
    }

    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                print("Tap");
                direction = Vector3.up * speed;
            }
        }
        direction.y += -19.6f * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
