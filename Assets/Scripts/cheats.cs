using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cheats : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] SpriteRenderer PlayerRen;
    [SerializeField] Toggle Invbool;
    [SerializeField] GameObject CheatPanel;
    [SerializeField] GameObject Floor;
    bool isInvisible;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            CheatPanel.SetActive(!CheatPanel.activeSelf);
        }
        isInvisible = Invbool.isOn;
        if (isInvisible == true)
        {
            PlayerRen.color = new Vector4(255, 255, 255, 0);
        }
        else
        {
            PlayerRen.color = new Vector4(255, 255, 255, 255);
        }
    }
    public void Tp1l()
    {
        print("niadfsa");
        Player.transform.position = new Vector3(103.14f, 10.17f, 14.63f);
    }
    public void Tp1el()
    {
        print("niadfsa");
        Player.transform.position = new Vector3(104.42f, 22.66f, 3.5f);
    }
    public void Tp2l()
    {
        print("niadfsa");
        Player.transform.position = new Vector3(158.01f, 31.94f, 3.48f);
    }
    public void Tp2el()
    {
        print("niadfsa");
        Player.transform.position = new Vector3(158.01f, 23.42f, 3.48f);
    }
    public void Tp3l()
    {
        print("niadfsa");
        Player.transform.position = new Vector3(258.04f, -9.08f, 3.48f);
    }
    public void TpR()
    {
        print("niadfsa");
        Player.transform.position = new Vector3(55.01f, -38.96f, 0.2f);
    }
    public void Destroy()
    {
        Instantiate(Floor, new Vector3(47.36f, -33.11f, 4), Quaternion.EulerRotation(0,0,0));
        
    }
}
