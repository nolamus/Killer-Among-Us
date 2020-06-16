using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AudioControls : MonoBehaviour
{
    // Start is called before the first frame update
    public  Slider BGMusicSlider;
    public AudioControlsReceiver AudioSender;
    public TextMeshProUGUI BGMusicDiplay;
    static float BGMusicVolume = 1f;
    void Start()
    {
        BGMusicSlider.value = BGMusicVolume;
    }


    // Update is called once per frame
    void Update()
    {
        BGMusicVolume = BGMusicSlider.value;
        BGMusicDiplay.text = "Volume: " + BGMusicVolume;
        AudioSender.SetBGMusicVolume(BGMusicVolume);

        
    }
}
