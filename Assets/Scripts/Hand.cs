using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public bool offM;
    public GameObject MonOff;
    public Animator anim4;
    public void Mon()
    {
        if (offM)
        {
            MonOff.SetActive(false);
            offM = false; 

        }
        else
        {
            MonOff.SetActive(true);
            offM = true; 
        }
    }
}
