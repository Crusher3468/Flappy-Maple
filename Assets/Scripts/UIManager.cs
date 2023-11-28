using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    //[SerializeField] Slider healthMeter;
    //[SerializeField] Slider shieldMeter;
    //[SerializeField] TMP_Text scoreUI;
    //[SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject TitleUI;
    [SerializeField] GameObject ShopUI;
    [SerializeField] GameObject LevelUI;
    [SerializeField] GameObject SettingsUI;
    [SerializeField] GameObject GameOverUI;

	public void ShowTitle(bool show)
    {
        TitleUI.SetActive(show);
    }

    public void ShowSettings(bool show)
    {
        SettingsUI.SetActive(show);
    }

    public void ShowShop(bool show)
    {
        ShopUI.SetActive(show);
    }

    public void ShowLevel(bool show)
    {
        LevelUI.SetActive(show);
    }

    public void ShowEnd(bool show)
    {
        GameOverUI.SetActive(show);
    }


    public void ShowGameOver(bool show)
    {
        //gameOverUI.SetActive(show);
    }

    public void SetHealth(int health)
    {
        //healthMeter.value = Mathf.Clamp(health, 0, 100);
    }

    public void SetShield(int shield)
    {
        //shieldMeter.value = Mathf.Clamp(shield, 0, 100);
    }

    public void SetScore(int score)
    {
        //scoreUI.text = score.ToString();
    }

}
