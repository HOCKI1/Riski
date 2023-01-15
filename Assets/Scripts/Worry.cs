using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worry : MonoBehaviour
{
    [SerializeField] float worrypoint;
    [SerializeField] float speed;
    bool camm;
    void Start()
    {
        worrypoint = 1;
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
         if (camm == false)
         {
            worrypoint += Time.deltaTime / Mathf.Sqrt(speed*1.5f) ;
            worrypoint = Mathf.Clamp(worrypoint, 0.09f, 1);
         }
        
        if (camm)
         {
            worrypoint -= Time.deltaTime /speed ;
            worrypoint = Mathf.Clamp(worrypoint, 0.09f, 1);

         }
    }
}
