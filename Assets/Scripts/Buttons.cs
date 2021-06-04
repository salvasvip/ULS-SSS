using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Buttons : MonoBehaviour
{
    void start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        
    }    
    public void Laberinto()
    {
        SceneManager.LoadScene(1);
        
    }
    public void Jugar()
    {
        SceneManager.LoadScene(1);
        
    }
    public void Instrucciones()
    {
        SceneManager.LoadScene(4);

    }
    public void Salir()
    {
        Application.Quit();
    }
    
}
