using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] GameObject SettingsObject;
    [SerializeField] Button AudioB;
    [SerializeField] Button VideoB;
    [SerializeField] GameObject Audio;
    [SerializeField] GameObject Video;
    [SerializeField] Slider MusicS;
    [SerializeField] Slider SoundS;
    [SerializeField] AudioSource MusicMenu;

    void Start() {
        if(PlayerPrefs.HasKey("Music") && PlayerPrefs.HasKey("Sound"))
        {
            MusicS.value = PlayerPrefs.GetFloat("Music", 0.5f);
            SoundS.value = PlayerPrefs.GetFloat("Sound", 0.5f);
        }
    }
    void Update() 
    {
        MusicMenu.volume = MusicS.value;
    }
    public void Restart()
    {
        PlayerPrefs.SetFloat("Sound", SoundS.value);
        PlayerPrefs.SetFloat("Music", MusicS.value);
        PlayerPrefs.Save();
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

    public void VideoBS() 
    {
        AudioB.interactable = true;
        VideoB.interactable = false;

        Audio.SetActive(false);
        Video.SetActive(true);
    }
}
