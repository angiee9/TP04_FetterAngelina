using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer AudioMixer;
    [SerializeField] private Slider musicSlider;

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        AudioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
    }
}
