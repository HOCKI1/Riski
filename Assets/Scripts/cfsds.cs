using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cfsds : MonoBehaviour
{
    [SerializeField] GameObject motherandMobile;
    [SerializeField] GameObject Camera2;
    [SerializeField] GameObject text;
    [SerializeField] GameObject Canvas;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.J)) {
           motherandMobile.SetActive(false);
           Camera2.SetActive(true);
           text.SetActive(true);
           Canvas.SetActive(false);

        }
        if(Input.GetKey(KeyCode.K)) {
           motherandMobile.SetActive(true);
           Camera2.SetActive(false);
           text.SetActive(false);
           Canvas.SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Canvas.SetActive(!Canvas.activeSelf);
        }
    }
}
