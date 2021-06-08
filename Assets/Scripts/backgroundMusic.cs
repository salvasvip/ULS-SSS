using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class backgroundMusic : MonoBehaviour
{
    public GameObject music;
    void Awake()
    {
        DontDestroyOnLoad(music);
        SceneManager.sceneLoaded += OnSceneLoad;
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        // DontDestroyOnLoad(this.gameObject);
    }
    void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == 4)
        {
            Destroy(music);
        }
    }
}
