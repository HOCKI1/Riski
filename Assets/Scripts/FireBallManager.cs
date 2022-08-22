using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallManager : MonoBehaviour
{
    [SerializeField] GameObject _FireBall;

    private void Start()
    {
        StartCoroutine("FRM");
    }
    IEnumerator FRM()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(_FireBall, transform.position, transform.rotation);
        }
    }
}
