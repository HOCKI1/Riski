using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.SetActive(!PausePanel.activeSelf);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Resume()
    {
        PausePanel.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
