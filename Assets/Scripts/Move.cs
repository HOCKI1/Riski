using UnityEngine;

public class Move : MonoBehaviour
{

    private int state;
    //ƒобавл€ем ссылку на компонент CharacterController в инспектор
    [SerializeField] CharacterController controller;
    //ƒобавл€ем ссылку на переменную speed (скорость игрока) в инспекторе
    [SerializeField] float speed = 5f;
    //—оздаем переменную гравитации дл€ падени€
    [SerializeField] float gravity = 50;
    //—оздаем переменную дл€ силы прыжка
    [SerializeField] float jumpForce = 40;
    Animator animator;
    //—оздаем переменную дл€ направлени€ движени€ игрока
    private Vector3 direction;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        // moveHorizontal будет принимать значение -1 если нажата кнопка A, 1 если нажата D, 0 если эти кнопки не нажаты
        float moveHorizontal = Input.GetAxis("Horizontal");
        // moveVertical будет принимать значение -1 если нажата кнопка S, 1 если нажата W, 0 если эти кнопки не нажаты
        //float moveVertical = Input.GetAxis("Vertical");

        
        if (controller.isGrounded) //провер€ем что мы неа земле (тема условий будет дальше)
        {
            direction = new Vector3(moveHorizontal, 0/*, moveVertical*/);
            //ƒополнительно умножа€ его на скорость передвижени€ (преобразу€ локальные координаты к глобальным)
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

            if (Input.GetKey(KeyCode.Space)) //ѕровер€ем что нажали пробел дл€ прыжка
            {
                direction.y = jumpForce;
                
            }

            //Ётой строчкой мы осуществл€ем изменение положени€ игрока на основе вектора direction
            //Time.deltaTime это количество секунд которое прошло с последнего кадра, дл€ синхронизации по времени

        }
        animator.SetInteger("state", state);
        //≈сли будете добавл€ть что-то св€занное с управлением, делайте это здесь

        direction.y -= gravity * Time.deltaTime;
        controller.Move(direction * Time.deltaTime);


    }
}