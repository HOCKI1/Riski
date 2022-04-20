using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerControl : MonoBehaviour
{
    public int level = 1;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "PlayerPlatformer")
        {
            level++;
            collision.gameObject.transform.position = new Vector3(1.076f, 3.743f, -3.097559f);
            switch(level)
            {
                case 2:
                    level1.SetActive(false);
                    level2.SetActive(true);
                    level3.SetActive(false);
                    level4.SetActive(false);
                    level5.SetActive(false);
                    break;
                case 3:
                    level1.SetActive(false);
                    level2.SetActive(false);
                    level3.SetActive(true);
                    level4.SetActive(false);
                    level5.SetActive(false);
                    break;
                case 4:
                    level1.SetActive(false);
                    level2.SetActive(false);
                    level3.SetActive(false);
                    level4.SetActive(true);
                    level5.SetActive(false);
                    break;
                case 5:
                    level1.SetActive(false);
                    level2.SetActive(false);
                    level3.SetActive(false);
                    level4.SetActive(false);
                    level5.SetActive(true);
                    break;
                case 6:
                    SceneManager.LoadScene(3);
                    if (PlayerPrefs.GetInt("Night") < 5)
                        PlayerPrefs.SetInt("Night", +1);
                    if (PlayerPrefs.GetInt("Night") == 5)
                        PlayerPrefs.SetInt("Night", PlayerPrefs.GetInt("Night"));
                    break;
            }  
        }
    }
}
