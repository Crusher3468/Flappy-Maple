using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField]
    private PointsTracker tracker;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Coin"))
        {
            tracker.SetCoins(tracker.GetCoins() + 1);
            GameManager.Instance.AddPoints(1);
            Destroy(collision.gameObject);
            Debug.Log(tracker.GetCoins());
        }
        else if (collision.gameObject.CompareTag("Point"))
        {
            tracker.SetScore(tracker.GetScore() + 1);
            Destroy(collision.gameObject);
        }
    }
}
