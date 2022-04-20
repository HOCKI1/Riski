using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Animator animator;
    private int state;


    //��������� ������ �� ��������� CharacterController � ���������
    [SerializeField] CharacterController controller;
    //��������� ������ �� ���������� speed (�������� ������) � ����������
    [SerializeField] float speed = 5f;
    //������� ���������� ���������� ��� �������
    [SerializeField] float gravity = 50;
    //������� ���������� ��� ���� ������
    [SerializeField] float jumpForce = 40;
    //������� ���������� ��� ����������� �������� ������
    private Vector3 direction;



    void Update()
    {
        
        animator.SetInteger("state", state);
        MoveLeftAndRight();
    }

    void MoveLeftAndRight()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            state = 3;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            state = 2;
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            state = 1;
        }
    }
}
