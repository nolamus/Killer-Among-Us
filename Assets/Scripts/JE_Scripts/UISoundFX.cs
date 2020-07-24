using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISoundFX : MonoBehaviour
{
    public AudioClip soundfx;
    private Button uibutton { get { return GetComponent<Button>(); } }
    private AudioSource uiSoundSource { get { return GetComponent<AudioSource>(); } }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        uiSoundSource.clip = soundfx;
        uiSoundSource.playOnAwake = false;

        uibutton.onClick.AddListener(() => SoundEffect());
    }

    void SoundEffect()
    {
        uiSoundSource.PlayOneShot(soundfx);
    }
}
