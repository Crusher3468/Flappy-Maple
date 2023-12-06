using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        if(collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.End();
            Destroy(collision.gameObject);
        }
    }
}
