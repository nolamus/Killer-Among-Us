/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioControls : MonoBehaviour
{
   
    public  Slider BGMusicSlider;   // Binds to slider gameObject for Background Music in Settings
    public AudioControlsReceiver AudioSender;   // Sends an Audio slider value in the settings menu to the AudioControlsReceiver's static variables
    public TextMeshProUGUI BGMusicDiplay;       // Binds to the text mesh displaying the current volume of the Background Music
    static float BGMusicVolume = 1f;            // static volume value for the Background Music slider

    void Start()
    {
        BGMusicSlider.value = BGMusicVolume;    // Set the slider value to the current background music volume
    }


    // Update is called once per frame
    void Update()
    {
        BGMusicVolume = BGMusicSlider.value;    // Set the Current Background Music volume to the value of the Background Music slider
        BGMusicDiplay.text = "Volume: " + BGMusicVolume; // Set the text displayed when the background music volume is changed
        AudioSender.SetBGMusicVolume(BGMusicVolume);    // Send the background music volume from the settings menu to to the Receiver class

        
    }
}
