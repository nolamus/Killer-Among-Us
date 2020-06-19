us/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
using UnityEngine;

public class AudioControlsReceiver : MonoBehaviour
{
    static float BGMusicVolume = 1f;
    public AudioSource BackgroundMusic;
    // Update is called once per frame
    void Update()
    {
        BackgroundMusic.volume = BGMusicVolume; // Update the volume value of the background music audio source
    }

    // Set the background music volume
    // Used to send volume data from the AudioControls class to the AudioControlsReciever class
    public void SetBGMusicVolume(float inputvolume)
    {
        BGMusicVolume = inputvolume;    
    }
}
