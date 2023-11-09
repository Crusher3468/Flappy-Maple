using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMovement : MonoBehaviour
{

    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private Vector2 direction = Vector2.left;

    private Vector3 movement = Vector2.zero;
    
    void Start()
    {
        movement = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += movement;
    }
}
