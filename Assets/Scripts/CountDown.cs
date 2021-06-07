using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float totalTime;

    public Text TextCuentaRegresiva;

    private float minutes;

    private float seconds;

    private string secondsText;
    private string minutesText;

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

        if (seconds < 10)
        {
            secondsText = "0" + seconds.ToString();

        }
        else
        {
            secondsText = seconds.ToString();
        }
        if (minutes < 10)
        {
            minutesText = "0" + minutes.ToString();
        }
        else
        {
            minutesText = minutes.ToString();
        }
        TextCuentaRegresiva.text = minutesText + ":" + secondsText;
        if (totalTime<=0)
        {
            SceneManager.LoadScene(4);
        }
    }
}
