using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControlsReceiver : MonoBehaviour
{
    static float BGMusicVolume;
    public AudioSource BackgroundMusic;
    // Update is called once per frame
    void Update()
    {
        BackgroundMusic.volume = BGMusicVolume;
    }

    public void SetBGMusicVolume(float inputvolume)
    {
        BGMusicVolume = inputvolume;
    }
}
