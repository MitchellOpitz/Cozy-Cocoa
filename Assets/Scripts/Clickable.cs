using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public SoundEffects soundEffects;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    private void OnMouseEnter()
    {
        soundEffects.PlaySound(hoverSound);
    }

    private void OnMouseDown()
    {
        soundEffects.PlaySound(clickSound);
    }
}
