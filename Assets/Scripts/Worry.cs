using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worry : MonoBehaviour
{
    [SerializeField] float worrypoint;
    bool camm;
    void Start()
    {
        worrypoint = 0;
        camm = false;

    }

    public void BoolT()
    {
        camm = true;
        
    }

    public void BoolF()
    {
        camm = false;
    }

    void Update()
    {
         if (camm = true)
         {
            worrypoint += Time.deltaTime;

         }
        
        if (camm = false)
         {
            worrypoint -= Time.deltaTime;

         }
    }
}
