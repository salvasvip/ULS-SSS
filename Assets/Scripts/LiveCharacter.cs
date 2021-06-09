using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LiveCharacter : MonoBehaviour
{
    public int playerHealth = 100;

    [SerializeField] int live = 100;
    [SerializeField] Text mensajeVida;
    [SerializeField] GameObject PanelBordeRojo;

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
                playerHealth = 100;
                PanelBordeRojo.SetActive(true);
                StartCoroutine("safe");
            }
            else
            {
                playerHealth -= damage;
            }
        }
        else
        {
            SceneManager.LoadScene(5);
        }
    }
    IEnumerator safe()
    {
        yield return new WaitForSeconds(1);
        PanelBordeRojo.SetActive(false);
    }
}
