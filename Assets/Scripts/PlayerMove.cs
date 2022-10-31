using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] SpriteRenderer sp;
    private int state;

    [SerializeField] float maxSpeed = 50;
    [SerializeField] float uskoreniya = 0.1f;
    [SerializeField] float jump = 50;
    float amplitudeX = 0;
    float amplitudeZ = 0;

    Animator animator;
    Rigidbody rb;
    [SerializeField] bool isGrounded;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jump, ForceMode.VelocityChange);
        }

        if (horizontal >= 0)
        {
            sp.flipX = true;
            if(isGrounded == true)
            {
                WalkingX(maxSpeed);

            }
        }
        if (horizontal <= 0)
        {
            sp.flipX = false;
            if (isGrounded == true)
            {
                WalkingX(-maxSpeed);
            }
        }
        else {
            rb.velocity = new Vector3(rb.velocity.x / 1.2f, rb.velocity.y, rb.velocity.z);
            amplitudeX = 0;
        }
        if (vertical >= 0)
        {
            
            if (isGrounded == true)
            {
                WalkingZ(maxSpeed);

            }
        }
        if (vertical <= 0)
        {
            
            if (isGrounded == true)
            {
                WalkingZ(-maxSpeed); 
            }
        }
        else
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z / 1.2f);
            amplitudeZ = 0;
        }
        if (isGrounded == false)
        {           
            if (horizontal >= .1)
            {
                state = 2;
            }
            if (horizontal <= -.1)
            {
                state = 2;
            }
            if (horizontal == 0)
            {
                state = 1;
            }
        
        }
       
        animator.SetInteger("state", state);
    }


    void OnCollisionStay(Collision other)
    {
        if(other.transform.tag == "Pol")
        {
            isGrounded = true;
        }
        

    }
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Damage")
        {
            transform.position = new Vector3(42.57f, 19.56f);
        }
    }


    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
        state = 3;
    }
    void WalkingX(float speed)
    {
        if (speed > 0)
        {
            amplitudeX += uskoreniya;
        }
        else
        {
            amplitudeX -= uskoreniya;
        }
        if (System.Math.Abs(amplitudeX) > maxSpeed)
        {
            amplitudeX = speed;
        }
        rb.velocity = new Vector3(amplitudeX, rb.velocity.y, rb.velocity.z);
    }
    void WalkingZ(float speed)
    {
        if (speed > 0)
        {
            amplitudeZ += uskoreniya;
        }
        else
        {
            amplitudeZ -= uskoreniya;
        }
        if (System.Math.Abs(amplitudeZ) > maxSpeed)
        {
            amplitudeZ = speed;
        }
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, amplitudeZ);
    }
}

