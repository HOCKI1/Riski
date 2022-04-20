using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Animator animator;
    private int state;


    //Добавляем ссылку на компонент CharacterController в инспектор
    [SerializeField] CharacterController controller;
    //Добавляем ссылку на переменную speed (скорость игрока) в инспекторе
    [SerializeField] float speed = 5f;
    //Создаем переменную гравитации для падения
    [SerializeField] float gravity = 50;
    //Создаем переменную для силы прыжка
    [SerializeField] float jumpForce = 40;
    //Создаем переменную для направления движения игрока
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
