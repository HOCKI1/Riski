using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Animator motherAnimator;
    [SerializeField] string room;
    [SerializeField] int stageroom = 0;
    [SerializeField] float speedMother;
    [SerializeField] public int hour;
    [SerializeField] int secondsInOneHour;


   // private float randNum = new Random.Range(1,24);
    //private float Random.Range(1,24)2 = Random.Range(0, 15);
    float timer;

    void Start()
    {
        RoomMother();
        
    }
    bool flag;
    void Update()
    {
        motherAnimator.SetInteger("stagerRoom", stageroom);
        switch(room)
        {
            case "Hallway":
                motherAnimator.SetBool("Hallway", true);
                motherAnimator.SetBool("Tualet", false);
                motherAnimator.SetBool("Kitchen", false);
                motherAnimator.SetBool("PlayerRoom", false);
                motherAnimator.SetBool("MotherRoom", false);
                break;
            case "Kitchen":
                motherAnimator.SetBool("Hallway", false);
                motherAnimator.SetBool("Tualet", false);
                motherAnimator.SetBool("Kitchen", true);
                motherAnimator.SetBool("PlayerRoom", false);
                motherAnimator.SetBool("MotherRoom", false);
                break;
            case "Bathroom":
                motherAnimator.SetBool("Hallway", false);
                motherAnimator.SetBool("Tualet", true);
                motherAnimator.SetBool("Kitchen", false);
                motherAnimator.SetBool("PlayerRoom", false);
                motherAnimator.SetBool("MotherRoom", false);
                break;
            case "RoomPlayer":
                motherAnimator.SetBool("Hallway", false);
                motherAnimator.SetBool("Tualet", false);
                motherAnimator.SetBool("Kitchen", false);
                motherAnimator.SetBool("PlayerRoom", true);
                motherAnimator.SetBool("MotherRoom", false);
                break;
            case "RoomMother":
                motherAnimator.SetBool("Hallway", false);
                motherAnimator.SetBool("Tualet", false);
                motherAnimator.SetBool("Kitchen", false);
                motherAnimator.SetBool("PlayerRoom", false);
                motherAnimator.SetBool("MotherRoom", true);
                break;

        }
       
        timer += Time.deltaTime;
       
        if (timer >= secondsInOneHour)
        {
            hour++;
            timer = 0;
        }
    }
    enum rooms
    {
        RoomMother,
        RoomPlayer,
        Bathroom,
        Kitchen
    }
    void motherMoving()
    {
        string randmove = ((rooms)Random.Range(0,3)).ToString();
        Invoke(randmove, Random.Range(1, 24));
    }

    public void RoomMother()
    {
        RM1();
        
        
    }
    void RM1()
    {
        stageroom = 0;
        room = "RoomMother";
        Invoke("RM2", Random.Range(1,24));

    }
    void RM2()
    {
        stageroom++;
        if (/*Random.Range(0, 1) == 0*/ false)
        {
            Invoke("RM1", Random.Range(1,24));
        }
        else
        {
            Invoke("RM3", Random.Range(1,24));
        }
    }
    void RM3()
    {
        stageroom++;
        Invoke("RM4", Random.Range(1,24));
    }
    void RM4()
    {
        stageroom++;
        if (/*Random.Range(0, 1) == 0*/ false)
        {
            Invoke("RM1", Random.Range(1,24));
        }
        else
        {
            Invoke("RM5", Random.Range(1,24));
        }

    }
    void RM5()
    {
        stageroom++;
        Invoke("Hallway", Random.Range(1,24));
    }
    public void RoomPlayer()
    {
        room = "RoomPlayer";
        if (player.playerInBed)
        {
            if(player.isActiveMonitor)
            {
                //MiniGame
            }
            else
            {
                room = "Hallway";
                Hallway();
            }
        }
        else
        {
            //Game Over
        }
    }

    public void Bathroom()
    {
        BR1();
       
    }
    void BR1()
    {
        stageroom = 0;
        room = "Bathroom";
        Invoke("BR2", Random.Range(1,24));
    }
    void BR2()
    {
        stageroom++;
        Invoke("BR3", Random.Range(1,24));
    }
    void BR3()
    {
        stageroom++;
        Invoke("Hallway", Random.Range(1,24));

    }
    public void Kitchen()
    {
        K1();
        
    }
    void K1()
    {
        room = "Kitchen";
        stageroom = 0;
        Invoke("K2", Random.Range(1,24));
    }
    void K2()
    {
        stageroom++;
        Invoke("K3", Random.Range(1,24));
    }
    void K3()
    {
        stageroom++;
        Invoke("Hallway", Random.Range(1,24));
    }
   
    public void Hallway()
    {
        room = "Hallway";
        stageroom = 0;
        motherMoving();
        

    }
}
