using UnityEngine;

public class Move : MonoBehaviour
{

    private int state;
    //��������� ������ �� ��������� CharacterController � ���������
    [SerializeField] CharacterController controller;
    //��������� ������ �� ���������� speed (�������� ������) � ����������
    [SerializeField] float speed = 5f;
    //������� ���������� ���������� ��� �������
    [SerializeField] float gravity = 50;
    //������� ���������� ��� ���� ������
    [SerializeField] float jumpForce = 40;
    Animator animator;
    //������� ���������� ��� ����������� �������� ������
    private Vector3 direction;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        // moveHorizontal ����� ��������� �������� -1 ���� ������ ������ A, 1 ���� ������ D, 0 ���� ��� ������ �� ������
        float moveHorizontal = Input.GetAxis("Horizontal");
        // moveVertical ����� ��������� �������� -1 ���� ������ ������ S, 1 ���� ������ W, 0 ���� ��� ������ �� ������
        //float moveVertical = Input.GetAxis("Vertical");

        
        if (controller.isGrounded) //��������� ��� �� ��� ����� (���� ������� ����� ������)
        {
            direction = new Vector3(moveHorizontal, 0/*, moveVertical*/);
            //������������� ������� ��� �� �������� ������������ (���������� ��������� ���������� � ����������)
            if(moveHorizontal >= .1)
            {
                //transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
                state = 2;
            }
            if (moveHorizontal <= -.1)
            {
                state = 3;
            }
            if(moveHorizontal == 0)
            {
                state = 1;
            }
            direction = transform.TransformDirection(direction) * speed;

            if (Input.GetKey(KeyCode.Space)) //��������� ��� ������ ������ ��� ������
            {
                direction.y = jumpForce;
                
            }

            //���� �������� �� ������������ ��������� ��������� ������ �� ������ ������� direction
            //Time.deltaTime ��� ���������� ������ ������� ������ � ���������� �����, ��� ������������� �� �������

        }
        animator.SetInteger("state", state);
        //���� ������ ��������� ���-�� ��������� � �����������, ������� ��� �����

        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);


    }
}