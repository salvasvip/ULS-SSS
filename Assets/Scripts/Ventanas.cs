using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventanas : MonoBehaviour
{
    [SerializeField] Animator AnimatorVentana1;
    [SerializeField] Animator AnimatorVentana2;
    [SerializeField] Animator AnimatorVentana3;
    [SerializeField] Animator AnimatorVentana4;
    [SerializeField] GameObject Player;
    [SerializeField] float buttonWindowRadius = 3f;
    private bool inButtonWindowRange;

    // Update is called once per frame
    void Update()
    {
        inButtonWindowRange = Vector3.Distance(transform.position, Player.transform.position) < buttonWindowRadius;
        if (inButtonWindowRange && Input.GetKeyDown(KeyCode.E))
        {
            AnimatorVentana1.SetBool("Cerrar", !(AnimatorVentana1.GetBool("Cerrar")));
            AnimatorVentana2.SetBool("Cerrar", !(AnimatorVentana2.GetBool("Cerrar")));
            AnimatorVentana3.SetBool("Cerrar", !(AnimatorVentana3.GetBool("Cerrar")));
            AnimatorVentana4.SetBool("Cerrar", !(AnimatorVentana4.GetBool("Cerrar")));
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, buttonWindowRadius);
    }
}
