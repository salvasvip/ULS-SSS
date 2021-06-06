using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OxygenCountDown : MonoBehaviour
{
    public float totalTime;

    public Text TextOxigeno;

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
        seconds = (int) (totalTime % 60);
        TextOxigeno.text = seconds.ToString();
        if (totalTime<=0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
