using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SettingsManager", order = 1)]
public class SettingsManager : ScriptableObject
{
    private float volume;

    public void SetVolume(float setValue)
    {
        volume = setValue;
        Debug.Log(setValue);
    }

    public float GetVolume()
    {
        return volume;
    }
}
