using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loaderscirpt : MonoBehaviour
{
    [SerializeField] Menu loader;
    // Start is called before the first frame update
    public void end_anim()
    {
        loader.Restart();

    }
}
