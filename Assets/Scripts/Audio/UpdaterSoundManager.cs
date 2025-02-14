using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdaterSoundManager : MonoBehaviour
{
    private float value;

    [SerializeField]
    private SliderWithLabel volume;

    private void Awake()
    {
        value = volume.GetValue();
        SoundManager.SetMasterVolume(value);
        volume.onValueChanged += OnVolumeChanged;
    }

    private void OnVolumeChanged(object sender, float value)
    {
        SetValue(value);
    }

    public void SetValue(float value)
    {
        this.value = value;
        SoundManager.SetMasterVolume(value);
    }

    public float GetValue()
    {
        return value;
    }
}
