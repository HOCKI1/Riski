using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public bool isActiveMonitor;
    [SerializeField] GameObject blackscreenMonitor;
    [SerializeField] public bool isMobileCall;

    [SerializeField] public bool playerInBed;
    [SerializeField] public bool doorOpened;
    [SerializeField] bool isWrapped;
    [SerializeField] public string stage = "Idle";
    bool onCamers;

    public void Monitor()
    {
        isActiveMonitor = !isActiveMonitor;
        blackscreenMonitor.SetActive(isActiveMonitor);
    }
    public void CheckCamers()
    {
        onCamers = !onCamers;
        if(onCamers)
        {
            stage = "CheckCam";
        }
        if(!onCamers)
        {
            stage = "Idle";
        }

    }
    public void OnBed()
    {
        playerInBed = !playerInBed;
        if (playerInBed)
        {
            stage = "OnBed";
        }
        if (!playerInBed)
        {
            stage = "Idle";
        }
        
    }
    public void Wrapped()
    {
        isWrapped = !isWrapped;
        if (isWrapped)
        {
            stage = "Wrapped";
        }
        if (!isWrapped)
        {
            stage = "Idle";
        }

    }
    public void Door()
    {
        doorOpened = !doorOpened;
    }
    public void Mobile()
    {
        isMobileCall = false;
    }
}
