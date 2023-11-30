using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource music;

    [SerializeField]
    private SettingsManager volumeSettings;

    private void Start()
    {
        music = GetComponent<AudioSource>();
        music.volume = volumeSettings.GetVolume();
    }

    public void UpdateVolume()
    {
        music.volume = volumeSettings.GetVolume();
    }
}
