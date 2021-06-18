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
    [SerializeField] GameObject GameObjectCodigo;
    [SerializeField] InputField InputFieldCodigo;
    [SerializeField] Text TextMensajesText;
    [SerializeField] AudioSource AudioSourceCloseWindow;
    private bool repared = false;
    private bool inRange = false;
    public Text TextReparaciones;
    public static int ReparacionesCompletadas = 0;
    public string codigo = "1234";

    void Update() {
        if(!repared && inRange)
        {
            GameObjectCodigo.SetActive(true);
            InputFieldCodigo.ActivateInputField();
            TextMensajesText.text = "el codigo es igual al nombre del bloque y la suma de los cubos de sus pasillos";
            if (Input.GetKeyDown(KeyCode.Return) && InputFieldCodigo.text == codigo)
            {
                Reparacion();
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        inRange = true;
    }

    void OnTriggerExit(Collider other) {
        InputFieldCodigo.text = "";
        TextMensajesText.text = "";
        GameObjectCodigo.SetActive(false);
        inRange = false;
    }
    
    public void Reparacion()
    {
        AudioSourceCloseWindow.Play();
        InputFieldCodigo.text = "";
        TextMensajesText.text = "";
        GameObjectCodigo.SetActive(false);
        repared = true;
        AnimatorVentana1.SetBool("Cerrar", true);
        AnimatorVentana2.SetBool("Cerrar", true);
        AnimatorVentana3.SetBool("Cerrar", true);
        AnimatorVentana4.SetBool("Cerrar", true);
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
