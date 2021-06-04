using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LiveCharacter : MonoBehaviour
{
    public int playerHealth = 10;

    [SerializeField] int live = 3;
    [SerializeField] Text mensajeVida;

    void Start()
    {
        mensajeVida.text = live.ToString();
    }

    public void PlayerHealth(int damage)
    {
        if (live>0)
        {
            if (playerHealth <= 0)
            {
                mensajeVida.text = (live - 1).ToString();
                live -= 1;
                playerHealth = 10;
            }
            else
            {
                playerHealth -= damage;
            }
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
}
