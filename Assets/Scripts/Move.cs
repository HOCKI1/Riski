using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    [SerializeField] SpriteRenderer sp;
    private int state;
    [SerializeField] bool isGrounded;
    
    [SerializeField] float speed = 5f;
    
    [SerializeField] float gravity = 50;
    
    [SerializeField] float jumpForce = 40;
    Animator animator;
    [SerializeField] Rigidbody rb;


    private Vector3 direction;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        // moveHorizontal ����� ��������� �������� -1 ���� ������ ������ A, 1 ���� ������ D, 0 ���� ��� ������ �� ������
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // moveVertical ����� ��������� �������� -1 ���� ������ ������ S, 1 ���� ������ W, 0 ���� ��� ������ �� ������

       
        if (moveHorizontal >= .1)
        {
            sp.flipX = true;
        }
        if (moveHorizontal <= -.1)
        {
            sp.flipX = false;
        }
        if (isGrounded == true) 
        {
            direction = new Vector3(moveHorizontal,  0, moveVertical);
            
            if (moveHorizontal >= .1)
            {
                state = 2;
            }
            if (moveHorizontal <= -.1)
            {
                state = 2;
            }
            if(moveHorizontal == 0)
            {
                state = 1;
            }

            direction = transform.TransformDirection(direction) * speed;
            if (Input.GetButton("Jump")) 
            {
                rb.velocity = new Vector3(0, jumpForce, 0);
               
                state = 3;
            }
        }
        else
        {
            state = 3;
        }
        
        animator.SetInteger("state", state);
        direction.x = moveHorizontal * speed;
        direction.z = moveVertical * speed;
        direction.y -= gravity * Time.deltaTime;
        //rb.AddRelativeForce(direction / speed, ForceMode.Impulse);
        rb.velocity = new Vector3(direction.x, rb.velocity.y, direction.z);
        

    }
    IEnumerator gravitu()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            rb.velocity = new Vector3(0, -8, 0);
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.transform.tag == "Pol")
        {
            isGrounded = true;
            StopCoroutine("gravitu");
        }
    }
    void OnCollisionExit(Collision other)
    {
        isGrounded = false;
        StartCoroutine("gravitu");
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Damage")
        {
            transform.position = new Vector3(42.57f, 19.56f);
        }
    }
}