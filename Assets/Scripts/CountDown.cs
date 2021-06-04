using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float totalTime;

    public Text text;

    private float minutes;

    private float seconds;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        minutes = (int) (totalTime / 60);
        seconds = (int) (totalTime % 60);
        text.text = minutes.ToString() + " : " + seconds.ToString();
        if (totalTime<=0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
