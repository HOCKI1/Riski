using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sdsd : MonoBehaviour
{
    [SerializeField] Transform player_;
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Player") {
            player_.position = new Vector3(71.6f, 10.01f,0.85f);
            print("NIGGA");
        }
        
    }
}
