using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip soundClip)
    {
        source.clip = soundClip;
        Debug.Log("Sound clip set to: " + soundClip);
        source.PlayOneShot(soundClip);
        Debug.Log("Sound clip played: " + soundClip);
    }
}
