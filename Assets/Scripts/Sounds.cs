using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource Shum;

    public void StartShum()
    {
        Shum.Play();
    }
    public void StopShum()
    {
        Shum.Stop();
    }
}
