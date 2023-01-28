using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MotherScript : MonoBehaviour
{
    [Header("Points")]
    
    bool Points = true;
    [SerializeField] Slider slider;
    [SerializeField] float TimePoint;
    [Header("Timer")]
    [SerializeField] Text hours;
    [SerializeField] float hous;
    [SerializeField] int Final;
    [Header("Animators")]
    [SerializeField] Animator anim;
    [SerializeField] Animator anim2;
    //[SerializeField] Animator anim3;
    [SerializeField] Animator anim4;
    [SerializeField] Animator anim5;
    [SerializeField] Animator anim6;
    //[SerializeField] Animator anim7;
    [SerializeField] Animator anim8;

    [SerializeField] float speedAnim;
    [SerializeField] Worry worry;
    [Header("RandomInt")]
    [SerializeField] float intrandom;
    [Header("ButtonsOber")]
    [SerializeField] Button Obernut;
    [SerializeField] GameObject ObernutG;
    [SerializeField] Button Obernut2;
    [SerializeField] GameObject ObernutG2;
    [Header("ButtonsBed")]
    [SerializeField] Button Bed;
    [SerializeField] GameObject BedG;
    [SerializeField] Button Bed2;
    [SerializeField] GameObject BedG2;
    [Header("Camerabut")]
    [SerializeField] Button cam;
    [SerializeField] GameObject camG;
    [SerializeField] Button cam2;
    [SerializeField] GameObject camG2;
    [SerializeField] GameObject blacks;
    [Header("monitorBut")]
    [SerializeField] Button Mon;
    [Header("Player")]
    [SerializeField] GameObject Player;
    [Header("telefon But")]
    [SerializeField] Button Buttont;
    
    [SerializeField] AudioSource Mobil;
    [Header("AudioSource")]
    [SerializeField] AudioSource one;
    [SerializeField] AudioSource two;
    [SerializeField] AudioSource three;
    [SerializeField] AudioSource four;
    [Header("Cams")]
    [SerializeField] GameObject Screncam1;
    [SerializeField] GameObject Screncam2;
    [SerializeField] GameObject Screncam3;
    [SerializeField] GameObject room2;
    [SerializeField] GameObject room3;
    
    //[SerializeField] AudioSource five;
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

    void Awake()
    {


        StartCoroutine("Mobila");
        
        if(PlayerPrefs.HasKey("Sound")) {
            one.volume = PlayerPrefs.GetFloat("Sound", 0.5f);
            two.volume = PlayerPrefs.GetFloat("Sound", 0.5f);
            three.volume = PlayerPrefs.GetFloat("Sound", 0.5f);
            //four.volume = PlayerPrefs.GetFloat("Sound", 0.5f);
            //five.volume = PlayerPrefs.GetFloat("Sound", 0.5f);
        }
    }
    private void Update()
    {
        speedAnim = worry.worrypoint;
        anim.speed = speedAnim;
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
        if (Points)
        { 
            slider.value += Time.deltaTime * TimePoint; 
        }
        if (!Points)
        {
            slider.value -= Time.deltaTime * TimePoint;
        }
        if (Motherintheroom )
        {
            Mon.interactable = false;
            cam2.interactable = false;
            cam.interactable = false;
            Bed2.interactable = false;
            Bed.interactable = false;
            Obernut2.interactable = false;
            Obernut.interactable = false;
        }
        if (slider.value == 0) { SceneManager.LoadScene(0); }
        
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
                break;
           

        }
        //if (Input.GetKeyDown(KeyCode.DownArrow)) {
        //    bool close = false;
        //    if(!close) {
        //        Cam1();
        //        close = true;
        //    }
        //    else if(close) {
        //        Cam3();
        //        close = false;
        //    }
        //    
        //
        //}
        //if (Input.GetKeyDown(KeyCode.UpArrow)) {
        //    monik();
        //
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow)) {
        //    bool close = false;
        //    if (!close) {
        //        Bed1();
        //        close = true;
        //    }
        //    else if (close) {
        //        Bed3();
        //        close = false;
        //    }
        //
        //
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow)) {
        //    bool close = false;
        //    if (!close) {
        //        Ober();
        //        close = true;
        //    }
        //    else if(close) {
        //       
        //        Ober2();
        //        close = false;
        //    }
        //
        //
        //}
  

       if (Input.GetKey(KeyCode.Alpha1))
        {
            Screncam1.SetActive(true);
            Screncam2.SetActive(false);
            Screncam3.SetActive(false);
            room2.SetActive(false);
            room3.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            Screncam1.SetActive(false);
            Screncam2.SetActive(true);
            Screncam3.SetActive(false);
            room2.SetActive(true);
            room3.SetActive(false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            Screncam1.SetActive(false);
            Screncam2.SetActive(false);
            Screncam3.SetActive(true);
            room2.SetActive(false);
            room3.SetActive(true);

        }


        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            Mobil.Stop();
            mobilasvonit = false;
            Buttont.interactable = false;
            anim4.SetTrigger("mobil");
            anim.SetTrigger("Mobil");
            anim6.SetTrigger("d");
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetTrigger("Hide");
            BedG.SetActive(false);
            BedG2.SetActive(true);
            bed = true;
            vstal = true;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetTrigger("check");
            camG2.SetActive(true);
            camG.SetActive(false);
            camm = true;
            vstal = true;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (offM) 
            {           
                anim.SetTrigger("mon"); 
                anim4.SetTrigger("go");
            }
            if (!offM) 
            {
           
               anim4.SetTrigger("go2");
                anim.SetTrigger("mon");

            }      
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            anim.SetTrigger("Abort");
            ObernutG.SetActive(false);
            ObernutG2.SetActive(true);
            obernut = true;
            vstal = true;
            
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
           
            if (number == 13 || number == 14 || number == 12)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("Next1");
                StartCoroutine("MotherS");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
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
            
            if (number == 15)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("Next2");
                StartCoroutine("MotherS2");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
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
            
            if (number == 12)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("Next3");
                StartCoroutine("MotherS3");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS2");
                
            }
            if (number == 15)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("Back2");
                StartCoroutine("Mother");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
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
            
            if (number == 17)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("Next4");
                StartCoroutine("MotherS4");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS3");

            }
            if (number == 37)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("kit1");
                StartCoroutine("MotherS4kit");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS3");

            }
            if (number == 27)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("tul1");
                StartCoroutine("MotherS1tul");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS3");

            }
        }
    }
    IEnumerator MotherS3kit()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            
            if (number == 41)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("kit2");
                StartCoroutine("MotherS4kit");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS3kit");

            }
           
        }
    }
    IEnumerator MotherS4kit()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            
            if (number == 31)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("kit3");
                StartCoroutine("MotherS5kit");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS4kit");

            }

        }
    }
    IEnumerator MotherS5kit()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            
            if (number == 31)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("tul1");
                StartCoroutine("MotherS1tul");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS5kit");

            }
            if (number == 15)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("wal");
                StartCoroutine("MotherWalk");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS5Kit");

            }
            if (number == 26)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("Back1");
                StartCoroutine("Mother");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS5Kit");

            }

        }
    }
    IEnumerator MotherS1tul()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            
            if (number == 31)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("tul2");
                StartCoroutine("MotherS2tul");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS1tul");

            }

        }
    }
    IEnumerator MotherS2tul()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            
            if (number == 31)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("tul3");
                StartCoroutine("MotherS3tul");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS2tul");

            }

        }
    }
    IEnumerator MotherS3tul()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            
            if (number == 11)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("wal");
                StartCoroutine("MotherWalk");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS3tul");

            }
            if (number == 1)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("Back1");
                StartCoroutine("Mother");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS3tul");

            }
            if (number == 46)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                anim5.SetTrigger("kit1");
                StartCoroutine("MotherS3kit");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS3tul");

            }

        }
    }
    IEnumerator MotherS4()
    {
        while (true)
        {
            yield return new WaitForSeconds(intrandom);
            var number = Random.Range(1, 50);
            
            if (number == 24)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                StartCoroutine("MotherS5");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
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
            
            if (number == 43)
            {
                blacks.SetActive(true);
                yield return new WaitForSeconds(0.7f);
                anim8.SetTrigger("Lamp");
                //anim7.SetTrigger("la");
                StartCoroutine("MotherWalk");
                yield return new WaitForSeconds(0.7f);
                blacks.SetActive(false);
                StopCoroutine("MotherS5");

                
            }
        }
    }
    IEnumerator MotherWalk()
    {
        while (true)
        {
            anim5.SetTrigger("wal");
            anim8.SetTrigger("Lamp");
            //anim7.SetTrigger("la");

            yield return new WaitForSeconds(11);
            Motherintheroom = true;
            
            if (offM && PlayerInBed)
            {
                anim5.SetTrigger("Idle");
                yield return new WaitForSeconds(5);
                anim5.SetTrigger("idle2");
                Motherintheroom = false;
                Bed2.interactable = true;

                StartCoroutine("Mother");
                StopCoroutine("MotherWalk");
            }
            else
            {
                anim5.SetTrigger("booo");
                anim.SetTrigger("boo");
                yield return new WaitForSeconds(3);
                SceneManager.LoadScene(0);
            }
        }
    }

    IEnumerator Mobila()
    {
        yield return new WaitForSeconds(Random.Range(20, 45));
        mobilasvonit = true;
        anim6.SetTrigger("j");
        Mobil.Play();
        if(!vstal)
        {
            Buttont.interactable = true;
        }
        StartCoroutine("Mobilavo");
    }
    IEnumerator Mobilavo()
    {
        yield return new WaitForSeconds(8);
        if (mobilasvonit)
        {
            StopCoroutine("MotherS");
            StopCoroutine("Mother");
            StopCoroutine("MotherS2");
            StopCoroutine("MotherS3");
            StopCoroutine("MotherS4");
            StopCoroutine("MotherS5");
            StartCoroutine("MotherWalk");
            Buttont.interactable = false;
            mobilasvonit = false;
            anim6.SetTrigger("d");
            Mobil.Stop();
        }
        StartCoroutine("Mobila");
        StopCoroutine("Mobilavo");
    }
    public void Ober()
    {
        
        anim.SetTrigger("Abort");
        ObernutG.SetActive(false);
        ObernutG2.SetActive(true);
        obernut = true;
        vstal = true;
    }
    public void Ober2()
    {
        anim.SetTrigger("abort 2");
        ObernutG2.SetActive(false);
        ObernutG.SetActive(true);
        obernut = false;
        vstal = false;
    }
    public void Bed1()
    {
        anim.SetTrigger("Hide");
        BedG.SetActive(false);
        BedG2.SetActive(true);
        bed = true;
        vstal = true;
    }
    public void Bed3()
    {
        anim.SetTrigger("Hide2");
        BedG.SetActive(true);
        BedG2.SetActive(false);
        bed = false;
        vstal = false;
    }
    public void Cam1()
    {
        anim.SetTrigger("check");
        camG2.SetActive(true);
        camG.SetActive(false);
        camm = true;
        vstal = true;
    }
    public void Cam3()
    {
        anim.SetTrigger("check2");
        camG2.SetActive(false);
        camG.SetActive(true);
        camm = false;
        vstal = false;
    }
    public void monik()
    {
        if (offM) 
        {           
            anim.SetTrigger("mon"); 
            anim4.SetTrigger("go");
        }
        if (!offM) 
        {
           
            anim4.SetTrigger("go2");
            anim.SetTrigger("mon");

        }      
    }
    public void noutclose()
    {
        anim2.SetTrigger("close");
        room2.SetActive(false);
        room3.SetActive(false);

    }
    public void noutopen()
    {
        anim2.SetTrigger("open");
        room2.SetActive(false);
        room3.SetActive(false);
        Screncam1.SetActive(true);
        Screncam2.SetActive(false);
        Screncam3.SetActive(false);
    }
    public void Mobilaa()
    {
        Mobil.Stop();
        mobilasvonit = false;
        Buttont.interactable = false;
        anim4.SetTrigger("mobil");
        anim.SetTrigger("Mobil");
        anim6.SetTrigger("d");
    }
    public void Offall()
    {
        if(bed && !camm && !obernut)
        {
            Bed2.interactable = true;
            cam2.interactable = false;
            cam.interactable = false;
            Bed.interactable = false;
            Obernut2.interactable = false;
            Obernut.interactable = false;
            Buttont.interactable = false;
            Mon.interactable = false;
            Player.SetActive(false);
        }
        if(!bed && !camm && !obernut )
        {
            Bed2.interactable = false;
            cam2.interactable = false;
            cam.interactable = false;
            Bed.interactable = false;
            Obernut2.interactable = false;
            Obernut.interactable = false;
            Buttont.interactable = false;
            Mon.interactable = false;
            Points = false;
            Player.SetActive(false);
        }
        if(camm  && !bed  && !obernut)
        {
            Bed2.interactable = false;
            cam2.interactable = true;
            cam.interactable = false;
            Bed.interactable = false;
            Obernut2.interactable = false;
            Obernut.interactable = false;
            Buttont.interactable = false;
            Mon.interactable = false;
            Points = false;
            Player.SetActive(false);
        }
        if(obernut  && !bed  && !camm )
        {
            Bed2.interactable = false;
            cam2.interactable = false;
            cam.interactable = false;
            Bed.interactable = false;
            Obernut2.interactable = true;
            Obernut.interactable = false;
            Buttont.interactable = false;
            Mon.interactable = false;
            Points = false;
            Player.SetActive(false);
        }
        Points = false;
        
    }
    public void Onall()
    {
        if(offM)
        {
            Points = false;
        }
        if(!offM)
        {
            Points = true;
        }
        if (mobilasvonit)
        {
            Buttont.interactable = true;
        }
        if (!mobilasvonit)
        {
            Buttont.interactable = false;
        }
        Bed2.interactable = false;
        cam2.interactable = false;
        cam.interactable = true;
        Bed.interactable = true;
        Obernut2.interactable = false;
        Obernut.interactable = true;      
        Mon.interactable = true;
        
        Player.SetActive(true);
    }
}


