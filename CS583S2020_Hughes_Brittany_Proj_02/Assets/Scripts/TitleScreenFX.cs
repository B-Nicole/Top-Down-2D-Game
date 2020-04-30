using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenFX : MonoBehaviour
{
    public AudioSource fx;
    public AudioClip hover;
    public AudioClip click;

    public void HoverSound()
    {
        fx.PlayOneShot(hover);
    }
    public void ClickSound()
    {
        fx.PlayOneShot(click);
    }
}
