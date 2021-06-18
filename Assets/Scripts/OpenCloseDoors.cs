using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCloseDoors : MonoBehaviour
{
    [SerializeField] Animator AnimatorPuerta;
    [SerializeField] GameObject ImageBotonE;
    [SerializeField] AudioSource AudioSourceOpenClose;
    public Text TextMensajesText;
    private bool inRange;
    private bool puertaCerrada = false;
    public static int puertasCerradas = 0;

    void Update()
    {
        if(inRange)
        {
            ImageBotonE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                AnimatorPuerta.SetBool("Cerrar", !(AnimatorPuerta.GetBool("Cerrar")));
                MensajeEstadoPuerta();
            }
        }
    }

    void MensajeEstadoPuerta()
    {
        puertaCerrada = !puertaCerrada;
        if(puertaCerrada)
        {
            puertasCerradas ++;
            TextMensajesText.text = "puerta cerrada";
            AudioSourceOpenClose.Play();
        }
        else
        {
            puertasCerradas --;
            TextMensajesText.text = "puerta abierta";
            AudioSourceOpenClose.Play();
        }
        StartCoroutine(TimeToMessage());
    }

    void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        inRange = false;
        ImageBotonE.SetActive(false);
    }

    IEnumerator TimeToMessage()
    {
        yield return new WaitForSeconds(3);
        TextMensajesText.text = "";
    }
}
