using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    // public OpenCloseDoors ocd;
    // public OpenCloseWindows ocw;

    // Update is called once per frame
    void Update()
    {
        if (OpenCloseDoors.puertasCerradas>=3 && OpenCloseWindows.ReparacionesCompletadas >=3)
        {
            SceneManager.LoadScene(6);
            OpenCloseDoors.puertasCerradas = 0;
            OpenCloseWindows.ReparacionesCompletadas = 0;
        }
    }
}
