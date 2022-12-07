using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Drawing;

public class Menu : MonoBehaviour
{
    [SerializeField] Animator perehod;
    [SerializeField] GameObject SettingsObject;
    [SerializeField] GameObject Play;
    [SerializeField] GameObject Exit;
    [SerializeField] GameObject Settinfs;
    [SerializeField] Button AudioB;
    [SerializeField] Button VideoB;
    [SerializeField] GameObject Audio;
    [SerializeField] GameObject Video;
    [SerializeField] Slider MusicS;
    [SerializeField] Slider SoundS;
    [SerializeField] AudioSource[] MusicMenu;
     int i;
    int FinishCount;
    [SerializeField] Animator PlayA;
    [SerializeField] Animator SettinfsA;
    [SerializeField] Animator exitA;
    void Start() {
        i = Random.Range(0, 8);
        MusicMenu[i].Play();
        if (PlayerPrefs.HasKey("Music") && PlayerPrefs.HasKey("Sound"))
        {
            MusicS.value = PlayerPrefs.GetFloat("Music");
            SoundS.value = PlayerPrefs.GetFloat("Sound");
        }
        PlayA = Play.GetComponent<Animator>();
        exitA = Exit.GetComponent<Animator>();
        SettinfsA = Settinfs.GetComponent<Animator>();


    }
    void Update() 
    {
        
        MusicMenu[i].volume = MusicS.value;
    }

    public void Playstart()
    {
        perehod.SetTrigger("start");

    }
    public void Restart()
    {
        print("Restart");
        Saving();
        SceneManager.LoadScene(1);
    }
    public void ExitTheGame()
    {
        Application.Quit();
    }
    public void SettingsMenu() 
    {
        SettingsObject.SetActive(!SettingsObject.activeSelf);
    }
    public void AudioBS() 
    {
        AudioB.interactable = false;
        VideoB.interactable = true;

        Audio.SetActive(true);
        Video.SetActive(false);
    }
    public void Planvost1()
    {
        PlayA.SetTrigger("on");
    }
    public void Planvost2()
    {
        SettinfsA.SetTrigger("on");
    }
    public void Planvost3()
    {
        exitA.SetTrigger("on");
    }
    public void nePlanvost1()
    {
        PlayA.SetTrigger("off");
    }
    public void nePlanvost2()
    {
        SettinfsA.SetTrigger("off");
    }
    public void nePlanvost3()
    {
        exitA.SetTrigger("off");
    }
    public void VideoBS() 
    {
        AudioB.interactable = true;
        VideoB.interactable = false;

        Audio.SetActive(false);
        Video.SetActive(true);
    }
    public void Saving()
    {
        PlayerPrefs.SetFloat("Sound", SoundS.value);
        PlayerPrefs.SetFloat("Music", MusicS.value);
        PlayerPrefs.Save();
    }
}
