using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : Singleton<PrefabManager>
{
    //GameManager gameManager;
    [SerializeField] SpriteRenderer skin;

    [SerializeField] Sprite prefab1;
    [SerializeField] Sprite prefab2;
    [SerializeField] Sprite prefab3;
    [SerializeField] Sprite prefab4;
    [SerializeField] Sprite prefab5;
    [SerializeField] Sprite prefab6;
    [SerializeField] Sprite prefab7;
    [SerializeField] Sprite prefab8;
    //[SerializeField] GameObject prefab9;


    public void Start()
    {
        //skin = gameManager.playerPrefab.GetComponent<SpriteRenderer>();
    }

    public void Skin1()
    {
        skin.sprite = prefab1;
    }

    public void Skin2()
    {
        skin.sprite = prefab2;
    }

    public void Skin3()
    {
        skin.sprite = prefab3;
    }
    public void Skin4()
    {
        skin.sprite = prefab4;
    }
    public void Skin5()
    {
        skin.sprite = prefab5;
    }
    public void Skin6()
    {
        skin.sprite = prefab6;
    }
    public void Skin7()
    {
        skin.sprite = prefab7;
    }
    public void Skin8()
    {
        skin.sprite = prefab8;
    }

}
