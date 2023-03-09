using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    [SerializeField] Mother mother;
    [SerializeField] Player player;

    [SerializeField] Text Hours;


    void Update()
    {
        Hours.text = mother.hour + "AM";
    }
}
