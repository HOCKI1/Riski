using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float maxSpeed = 50;
    [SerializeField] float uskoreniya = 0.1f;
    [SerializeField] float jamp = 50;

    Rigidbody rb;
    float amplitude = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            Walking(maxSpeed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Walking(-maxSpeed);
        } else
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.2f, rb.velocity.y, 0);
            amplitude = 0;
        }
           

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jamp, ForceMode.VelocityChange);
        }
    }

    void Walking(float speed)
    {
        if(speed > 0)
        {
            amplitude += uskoreniya;
        }
        else
        {
            amplitude -= uskoreniya;
        }
        if(System.Math.Abs(amplitude) > maxSpeed)
        {
            amplitude = speed;
        }
        rb.velocity = new Vector3(amplitude, rb.velocity.y, 0);
    }
}
