using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puertas : MonoBehaviour
{
    [SerializeField] Animator AnimatorPuerta;
    [SerializeField] GameObject Player;
    [SerializeField] float buttonDoorRadius = 3f;
    private bool inButtonDoorRange;

    // Update is called once per frame
    void Update()
    {
        inButtonDoorRange = Vector3.Distance(transform.position, Player.transform.position) < buttonDoorRadius;
        if (inButtonDoorRange && Input.GetKeyDown(KeyCode.E))
        {
            AnimatorPuerta.SetBool("Cerrar", !(AnimatorPuerta.GetBool("Cerrar")));
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, buttonDoorRadius);
    }
}
