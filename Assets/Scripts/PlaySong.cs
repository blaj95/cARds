using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySong : MonoBehaviour
{
    public AudioSource source;

    public void Play()
    {
        source.Play();
    }
}
