using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public static bool paused = false;
    public GameObject pauseMenuUI;
    private AudioSource[] allAudioSources;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressedP();
        }
    }

    void PauseAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach(AudioSource audioS in allAudioSources)
        {
            audioS.Pause();
        }
    }

    void UnPauseAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach(AudioSource audioS in allAudioSources)
        {
            audioS.UnPause();
        }
    }

    void pressedP()
    {
        if(paused)
        {
            UnPauseAllAudio();
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            paused = !paused;
        }
        else
        {
            paused = !paused;
            PauseAllAudio();
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    // public void Resume()
    // {
    //     UnPauseAllAudio();
    //     pauseMenuUI.SetActive(false);
    //     Time.timeScale = 1f;
    //     gameIsPaused = false;
    // }
    // void Pause()
    // {
    //     PauseAllAudio();
    //     pauseMenuUI.SetActive(true);
    //     Time.timeScale = 0f;
    //     gameIsPaused = true;
    // }
}
