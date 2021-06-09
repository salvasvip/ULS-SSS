using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoors : MonoBehaviour
{
    [SerializeField] Animator AnimatorPuerta;
    [SerializeField] GameObject ImageBotonE;

    void OnTriggerStay(Collider other) {
        ImageBotonE.SetActive(true);
        if (Input.GetKeyDown(KeyCode.E))
        {
            AnimatorPuerta.SetBool("Cerrar", !(AnimatorPuerta.GetBool("Cerrar")));
        }
    }
    void OnTriggerExit(Collider other) {
        ImageBotonE.SetActive(false);
    }
}
