using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MotherScript : MonoBehaviour
{
    [Header("Points")]
    bool Points = true;
    public Slider slider;
    public float TimePoint;
    [Header("Timer")]
    public Text hours;
    public float hous;
    public int Final;
    [Header("Animators")]
    public Animator anim;
    public Animator anim2;
    public Animator anim3;
    public Animator anim4;
    public Animator anim5;
    public Animator anim6;
    [Header("RandomInt")]
    public float intrandom;
    [Header("ButtonsOber")]
    public GameObject Obernut;
    public GameObject Obernut2;
    [Header("ButtonsBed")]
    public GameObject Bed;
    public GameObject Bed2;
    [Header("Camerabut")]
    public GameObject cam;
    public GameObject cam2;
    [Header("monitorBut")]
    public GameObject Mon;
    [Header("Player")]
    public GameObject Player;
    [Header("ScreansCam")]
    public GameObject Screen1;
    public GameObject Screen2;
    public GameObject Screen3;
    public GameObject Screen4;
    public GameObject Screen5;
    public GameObject Screen6;
    [Header("telefon But")]
    public GameObject Buttont;
    public AudioSource Mobil;
    [Header("Bools")]
    bool offM;
    bool PlayerInBed;
    bool Motherintheroom;
    public bool mobilasvonit;
    bool camm;
    bool bed;
    bool obernut;
    bool vstal;
    
    public GameObject MonOff;
    public GameObject Hand;

    void Start()
    {
        StartCoroutine("Mobila");
        
        PlayerInBed = false;
        cam2.SetActive(false);
        Obernut2.SetActive(false);
        Bed2.SetActive(false);
    }
    private void Update()
    {
        hous += Time.deltaTime;
        offM = Hand.GetComponent<Hand>().offM;
        if (hous >= 80f)
        {

            Final++; hous = 0;
            hours.text = Final + "AM";
            if (Final == 1)
            {
                StartCoroutine("Mother");
            }
        }
        if (Points == true)
        { 
            slider.value += Time.deltaTime * TimePoint; 
        }
        else 
        {
            slider.value -= Time.deltaTime * TimePoint;
        }
        if (Motherintheroom == true)
        {
            Mon.GetComponent<Button>().interactable = false;
            cam2.GetComponent<Button>().interactable = false;
            cam.GetComponent<Button>().interactable = false;
            Bed2.GetComponent<Button>().interactable = false;
            Bed.GetComponent<Button>().interactable = false;
            Obernut2.GetComponent<Button>().interactable = false;
            Obernut.GetComponent<Button>().interactable = false;
        }
        if (slider.value == 0) { SceneManager.LoadScene(2); }
        
        switch (Final)
        {
            case 1:
                intrandom = 1;
                break;

            case 2:
                intrandom = 0.8f;
                break;

            case 3:
                intrandom = 0.6f;
                break;

            case 4:
                intrandom = 0.4f;
                break;

            case 5:
                intrandom = 0.3f;
                break;

            case 6:
                SceneManager.LoadScene(3);
                print("æîñêà");
                break;
        }
    }
    public void PIBT()
    {
        PlayerInBed = true;
    }
    public void PIBF()
    {
        PlayerInBed = false;
    }
    
    IEnumerator Mother()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            print(number);
            if (number == 13 || number == 14 || number == 12)
            {
                anim3.SetTrigger("vhs");
                Screen2.SetActive(true);
                Screen3.SetActive(false);
                Screen1.SetActive(false);
                Screen4.SetActive(false);
                Screen5.SetActive(false);
                Screen6.SetActive(false);
                StartCoroutine("MotherS");
                StopCoroutine("Mother");

            }
        }
    }
    IEnumerator MotherS()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            print(number);
            if (number == 15)
            {
                anim3.SetTrigger("vhs");
                Screen3.SetActive(true);
                Screen2.SetActive(false);
                Screen1.SetActive(false);
                Screen4.SetActive(false);
                Screen5.SetActive(false);
                Screen6.SetActive(false);
                StartCoroutine("MotherS2");
                StopCoroutine("MotherS");

            }
        }
    }
    IEnumerator MotherS2()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            print(number);
            if (number == 12)
            {
                anim3.SetTrigger("vhs");
                Screen4.SetActive(true);
                Screen3.SetActive(false);
                Screen2.SetActive(false);
                Screen1.SetActive(false);
                Screen5.SetActive(false);
                Screen6.SetActive(false);
                StartCoroutine("MotherS3");
                StopCoroutine("MotherS2");
            }
            if (number == 15)
            {
                anim3.SetTrigger("vhs");
                Screen1.SetActive(true);
                Screen2.SetActive(false);
                Screen3.SetActive(false);
                Screen4.SetActive(false);
                Screen5.SetActive(false);
                Screen6.SetActive(false);
                StartCoroutine("Mother");
                StopCoroutine("MotherS2");
            }
        }
    }
    IEnumerator MotherS3()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            print(number);
            if (number == 17)
            {
                anim3.SetTrigger("vhs");
                Screen5.SetActive(true);
                Screen4.SetActive(false);
                Screen1.SetActive(false);
                Screen2.SetActive(false);
                Screen3.SetActive(false);
                Screen6.SetActive(false);
                StartCoroutine("MotherS4");
                StopCoroutine("MotherS3");
            }
        }
    }
    IEnumerator MotherS4()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            print(number);
            if (number == 24)
            {
                anim3.SetTrigger("vhs");
                StartCoroutine("MotherS5");
                StopCoroutine("MotherS4");
            }
           
        }
    }
    IEnumerator MotherS5()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            print(number);
            if (number == 47)
            {
                anim3.SetTrigger("vhs");
                Screen6.SetActive(true);
                Screen5.SetActive(false);
                Screen1.SetActive(false);
                Screen2.SetActive(false);
                Screen3.SetActive(false);
                Screen4.SetActive(false);
                StartCoroutine("MotherWalk");
                StopCoroutine("MotherS5");

            }
        }
    }
    IEnumerator MotherWalk()
    {
        while (true)
        {
            anim5.SetTrigger("wal");
            yield return new WaitForSeconds(11);
            Motherintheroom = true;
            if (offM == true && PlayerInBed == true)
            {
                anim5.SetTrigger("Idle");
                yield return new WaitForSeconds(5);
                anim5.SetTrigger("idle2");
                Motherintheroom = false;
                Bed2.GetComponent<Button>().interactable = true;
                Screen6.SetActive(false);
                Screen1.SetActive(true);
                StartCoroutine("Mother");
                StopCoroutine("MotherWalk");
            }
            else
            {
                anim5.SetTrigger("booo");
                anim.SetTrigger("boo");
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene(1);
            }
        }
    }

    IEnumerator Mobila()
    {
        yield return new WaitForSeconds(Random.Range(20, 45));
        mobilasvonit = true;
        anim6.SetTrigger("j");
        Mobil.Play();
        if(vstal == false)
        {
            Buttont.GetComponent<Button>().interactable = true;
        }
        StartCoroutine("Mobilavo");
    }
    IEnumerator Mobilavo()
    {
        yield return new WaitForSeconds(8);
        if (mobilasvonit == true)
        {
            StopCoroutine("MotherS");
            StopCoroutine("Mother");
            StopCoroutine("MotherS2");
            StopCoroutine("MotherS3");
            StopCoroutine("MotherS4");
            StopCoroutine("MotherS5");
            StartCoroutine("MotherWalk");
            Buttont.GetComponent<Button>().interactable = false;
        }
        StartCoroutine("Mobila");
        StopCoroutine("Mobilavo");
    }
    public void Ober()
    {
        
        anim.SetTrigger("Abort");
        Obernut.SetActive(false);
        Obernut2.SetActive(true);
        obernut = true;
        vstal = true;
    }
    public void Ober2()
    {
        anim.SetTrigger("abort 2");
        Obernut2.SetActive(false);
        Obernut.SetActive(true);
        obernut = false;
        vstal = false;
    }
    public void Bed1()
    {
        anim.SetTrigger("Hide");
        Bed.SetActive(false);
        Bed2.SetActive(true);
        bed = true;
        vstal = true;
    }
    public void Bed3()
    {
        anim.SetTrigger("Hide2");
        Bed.SetActive(true);
        Bed2.SetActive(false);
        bed = false;
        vstal = false;
    }
    public void Ñam1()
    {
        anim.SetTrigger("check");
        cam2.SetActive(true);
        cam.SetActive(false);
        camm = true;
        vstal = true;
    }
    public void Cam3()
    {
        anim.SetTrigger("check2");
        cam2.SetActive(false);
        cam.SetActive(true);
        camm = false;
        vstal = false;
    }
    public void monik()
    {
        if (offM == true) 
        {           
            anim.SetTrigger("mon"); 
            anim4.SetTrigger("go");

        }
        else
        {
           
            anim4.SetTrigger("go2");
            anim.SetTrigger("mon");

           
        }      
    }
    public void noutclose()
    {
        anim2.SetTrigger("close");
    }
    public void noutopen()
    {
        anim2.SetTrigger("open");
    }
    public void Mobilaa()
    {
        Mobil.Stop();
        mobilasvonit = false;
        Buttont.GetComponent<Button>().interactable = false;
        anim4.SetTrigger("mobil");
        anim.SetTrigger("Mobil");
        anim6.SetTrigger("d");
        
    }
    public void Offall()
    {
        if(bed == true && camm == false && obernut == false)
        {
            Bed2.GetComponent<Button>().interactable = true;
            cam2.GetComponent<Button>().interactable = false;
            cam.GetComponent<Button>().interactable = false;
            Bed.GetComponent<Button>().interactable = false;
            Obernut2.GetComponent<Button>().interactable = false;
            Obernut.GetComponent<Button>().interactable = false;
            Buttont.GetComponent<Button>().interactable = false;
            Mon.GetComponent<Button>().interactable = false;
            Player.SetActive(false);
        }
        if(bed == false && camm == false && obernut == false)
        {
            Bed2.GetComponent<Button>().interactable = false;
            cam2.GetComponent<Button>().interactable = false;
            cam.GetComponent<Button>().interactable = false;
            Bed.GetComponent<Button>().interactable = false;
            Obernut2.GetComponent<Button>().interactable = false;
            Obernut.GetComponent<Button>().interactable = false;
            Buttont.GetComponent<Button>().interactable = false;
            Mon.GetComponent<Button>().interactable = false;
            Points = false;
            Player.SetActive(false);
        }
        if(camm == true && bed == false && obernut == false)
        {
            Bed2.GetComponent<Button>().interactable = false;
            cam2.GetComponent<Button>().interactable = true;
            cam.GetComponent<Button>().interactable = false;
            Bed.GetComponent<Button>().interactable = false;
            Obernut2.GetComponent<Button>().interactable = false;
            Obernut.GetComponent<Button>().interactable = false;
            Buttont.GetComponent<Button>().interactable = false;
            Mon.GetComponent<Button>().interactable = false;
            Points = false;
            Player.SetActive(false);
        }
        if(obernut == true && bed == false && camm == false)
        {
            Bed2.GetComponent<Button>().interactable = false;
            cam2.GetComponent<Button>().interactable = false;
            cam.GetComponent<Button>().interactable = false;
            Bed.GetComponent<Button>().interactable = false;
            Obernut2.GetComponent<Button>().interactable = true;
            Obernut.GetComponent<Button>().interactable = false;
            Buttont.GetComponent<Button>().interactable = false;
            Mon.GetComponent<Button>().interactable = false;
            Points = false;
            Player.SetActive(false);
        }
        Points = false;
        
    }
    public void Onall()
    {
        if(offM == true)
        {
            Points = false;
        }
        else
        {
            Points = true;
        }
        if (mobilasvonit == true)
        {
            Buttont.GetComponent<Button>().interactable = true;
        }
        else
        {
            Buttont.GetComponent<Button>().interactable = false;
        }
        Bed2.GetComponent<Button>().interactable = false;
        cam2.GetComponent<Button>().interactable = false;
        cam.GetComponent<Button>().interactable = true;
        Bed.GetComponent<Button>().interactable = true;
        Obernut2.GetComponent<Button>().interactable = false;
        Obernut.GetComponent<Button>().interactable = true;      
        Mon.GetComponent<Button>().interactable = true;
        
        Player.SetActive(true);
    }
}
