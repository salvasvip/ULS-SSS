using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public float waitTime = 7f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForIntro());
        
    }

    IEnumerator WaitForIntro()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(1);
        
    }

}
