using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetVolume(float volume) //громкость
    {
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    public void SetQuality(int qualityIndex) //рахрешение
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void Sound() //вкыл-выкл звука
    {
        AudioListener.pause = !AudioListener.pause;
    }
}