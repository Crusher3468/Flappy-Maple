using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEraser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject.transform.parent.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
