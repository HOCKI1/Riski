using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] SpriteRenderer sp;
    private int state;

    [SerializeField] float speed;
    [SerializeField] float JumpForce;

    Animator animator;
    Rigidbody rb;
    [SerializeField] bool isGrounded;

    Vector3 direction;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        direction = transform.TransformDirection(horizontal, 0, vertical);
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0,15,0);
        }


        if (horizontal >= .1)
        {
            sp.flipX = true;
        }
        if (horizontal <= -.1)
        {
            sp.flipX = false;
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
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + speed * direction * Time.deltaTime);
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
        StopCoroutine("gravitu");
    }
}

