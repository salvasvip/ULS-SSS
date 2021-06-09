using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCloseWindows : MonoBehaviour
{
    [SerializeField] Animator AnimatorVentana1;
    [SerializeField] Animator AnimatorVentana2;
    [SerializeField] Animator AnimatorVentana3;
    [SerializeField] Animator AnimatorVentana4;
    [SerializeField] GameObject ImageBotonE;
    [SerializeField] Text TextMensajesText;
    private bool repared = false;
    private bool inRange = false;
    public Text TextReparaciones;
    public static int ReparacionesCompletadas = 0;

    void Update() {
        if(!repared && inRange)
        {
            ImageBotonE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                repared = true;
                ImageBotonE.SetActive(false);
                AnimatorVentana1.SetBool("Cerrar", true);
                AnimatorVentana2.SetBool("Cerrar", true);
                AnimatorVentana3.SetBool("Cerrar", true);
                AnimatorVentana4.SetBool("Cerrar", true);
                Reparacion();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }

    void OnTriggerExit(Collider other) {
        inRange = false;
        ImageBotonE.SetActive(false);
    }
    
    public void Reparacion()
    {
        ReparacionesCompletadas++;
        TextReparaciones.text = ReparacionesCompletadas.ToString() + "/3";
        TextMensajesText.text = "VENTANAS SELLADAS";
        StartCoroutine(TimeToMessage());
    }

    IEnumerator TimeToMessage()
    {
        yield return new WaitForSeconds(3);
        TextMensajesText.text = "";
    }
}
