using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/PointsTracker", order = 2)]
public class PointsTracker : ScriptableObject
{
    [SerializeField]
    private int coins;
    [SerializeField]
    private int score;

    public void SetCoins(int num)
    {
        coins = num;
    }

    public void SetScore(int num)
    {
        score = num;
    }

    public int GetCoins()
    {
        return coins;
    }

    public int GetScore()
    {
        return score;
    }
}
