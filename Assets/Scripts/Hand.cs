using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public bool offM;
    public GameObject MonOff;
    public Animator anim;
    public Animator anim4;
    public void Mon()
    {
        if (offM == true)
        {
            MonOff.SetActive(false);
            offM = false; 

            print("dsdssssdsds");
        }
        else
        {
            MonOff.SetActive(true);
            offM = true; 
        }
    }
}
