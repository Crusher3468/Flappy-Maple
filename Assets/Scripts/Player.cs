using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int points;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        Animator animator = GetComponent<Animator>();

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if(spriteRenderer.sprite.name != "flappy-bird_Neon_2")
        {
            animator.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoints(int add)
    {
        points += add;
    }

    public int GetPoints()
    {
        return points;
    }

    public void AddScore(int add)
    {
        score += add;
    }

    public int GetScore()
    {
        return score;
    }
}
