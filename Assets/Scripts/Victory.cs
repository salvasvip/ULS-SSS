using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    // public int NumeroAliens = 0;
    // GameObject[] npcs = GameObject.FindGameObjectsWithTag("Alien");
    // int numberOfNPCS = npcs.Length;
    // void Start()
    // {
    //     Debug.Log(numberOfNPCS);
    // }

    void Update()
    {
        if (OpenCloseDoors.puertasCerradas>=3 && OpenCloseWindows.ReparacionesCompletadas >=3)//NumeroAliens >= 6
        {
            SceneManager.LoadScene(6);
            OpenCloseDoors.puertasCerradas = 0;
            OpenCloseWindows.ReparacionesCompletadas = 0;
        }
    }

    // void OnTriggerEnter(Collider other)
    // {
    //     NumeroAliens++;
        // Debug.Log(NumeroAliens);
        // if (other.gameObject.tag == "Alien")
        // {
        // }
    // }

    // void OnTriggerExit(Collider other)
    // {
        // NumeroAliens--;
        // Debug.Log(NumeroAliens);
        // if (other.gameObject.tag == "Alien")
        // {
        // }
    // }

}
