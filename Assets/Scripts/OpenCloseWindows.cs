using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseWindows : MonoBehaviour
{
    [SerializeField] Animator AnimatorVentana1;
    [SerializeField] Animator AnimatorVentana2;
    [SerializeField] Animator AnimatorVentana3;
    [SerializeField] Animator AnimatorVentana4;
    [SerializeField] GameObject ImageBotonE;
    
    void OnTriggerStay(Collider other) {
        ImageBotonE.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            AnimatorVentana1.SetBool("Cerrar", true);
            AnimatorVentana2.SetBool("Cerrar", true);
            AnimatorVentana3.SetBool("Cerrar", true);
            AnimatorVentana4.SetBool("Cerrar", true);
        }
    }
    void OnTriggerExit(Collider other) {
        ImageBotonE.SetActive(false);
    }
}
