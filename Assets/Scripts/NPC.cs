using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    Rigidbody rb;
    int LR;
    Animator anim;
    SpriteRenderer sp; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        StartCoroutine("walk");
    }

    IEnumerator walk() {
        while(true) 
        {
            yield return new WaitForSeconds(Random.Range(1, 10));          
            
            LR = Random.Range(1,10);
            if(LR >= 5) {
                rb.AddForce(Vector3.left * Random.Range(700,1000));
                anim.SetTrigger("Go");
                sp.flipX = false;
                yield return new WaitForSeconds(Random.Range(1, 3));
                anim.SetTrigger("Go2");
            }
            if(LR <= 5) {
                rb.AddForce(Vector3.right * Random.Range(700,1000));
                sp.flipX = true;
                anim.SetTrigger("Go");
                yield return new WaitForSeconds(Random.Range(1, 3));
                anim.SetTrigger("Go2");
            }
            
        }
    }
}
