using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mother : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] string room = "MotherRoom";
    [SerializeField] int stageroom = 0;
    [SerializeField] float speedMother;
    [SerializeField] public int hour;
    [SerializeField] int secondsInOneHour;
    int maxRandom = 80;
    float timer;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= secondsInOneHour)
        {
            hour++;
            timer = 0;
        }
    }

    public void RoomMother()
    {
        int i;
        while(stageroom == 0)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom++;
            }
        }
        while (stageroom == 1)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom++;
            }
            if (i == 0)
            {
                stageroom--;
            }
        }
        while (stageroom == 2)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom++;
            }
        }
        while (stageroom == 3)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom++;
            }
            if (i == 0)
            {
                stageroom = 0;
            }
        }
        while (stageroom == 4)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                room = "Hallway";
                stageroom = 0;
            }
        }
    }
    public void RoomPlayer()
    {
        if(player.playerInBed)
        {
            if(player.isActiveMonitor)
            {
                //MiniGame
            }
            else
            {
                room = "Hallway";
            }
        }
        else
        {
            //Game Over
        }
    }
    public void Bathroom()
    {
        int i;
        while (stageroom == 0)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom++;
            }
        }
        while (stageroom == 1)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom++;
            }
        }
        while (stageroom == 2)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom = 0;
                room = "Hallway";
            }
        }
    }
    public void Kitchen()
    {
        int i;
        while(stageroom == 0)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom++;
            }
        }
        while (stageroom == 1)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom++;
            }
        }
        while (stageroom == 2)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if (i == 15)
            {
                stageroom = 0;
                room = "Hallway";
            }
        }
    }
    public void Hallway()
    {
        int i;
        while(stageroom == 0)
        {
            new WaitForSeconds(speedMother);
            i = Random.Range(0, maxRandom);
            if(i == 15)
            {
                i = Random.Range(0, 2);
                switch(i) {
                    case 0:
                        room = "kitchen";
                        break;
                    case 1:
                        room = "Bathroom";
                        break;
                    case 2:
                        room = "RoomPlayer";
                        break;
                }
            }
        }
    }
}
