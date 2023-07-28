using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource laser;
    public void play()
    {
        laser.Play();
    }
}
