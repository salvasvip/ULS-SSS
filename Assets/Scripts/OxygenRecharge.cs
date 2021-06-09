using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenRecharge : MonoBehaviour
{
    public OxygenCountDown OxygenRemainingTime;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject ImageBotonE;
    [SerializeField] GameObject TextMensajesObject;
    [SerializeField] GameObject CylinderOxigeno;
    private Renderer CylinderOxigenoRenderer;
    [SerializeField] Text TextMensajesText;
    [SerializeField] AudioSource rechargeOxygenAudioSource;
    private bool usado = false;
    
    void Start()
    {
        CylinderOxigenoRenderer = CylinderOxigeno.GetComponent<Renderer>();
    }
        void OnTriggerStay(Collider other) {
            if(!usado)
            {
                ImageBotonE.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    OxigenoUsado();
                    }
            }
        }
        void OnTriggerExit(Collider other) {
            ImageBotonE.SetActive(false);
        }

    void OxigenoUsado()
    {
        usado=true;
        ImageBotonE.SetActive(false);
        rechargeOxygenAudioSource.Play();
        Color CilindroOxigenoColor = new Color(.5f,.1f,.1f,.5f);
        CylinderOxigenoRenderer.material.SetColor("_Color",CilindroOxigenoColor);
        OxygenRemainingTime.totalTime = 60;
        TextMensajesText.text = "tanque de oxigeno recargado";
        TextMensajesObject.SetActive(true);
        StartCoroutine("TimeToMessage");
    }

    IEnumerator TimeToMessage()
    {
        yield return new WaitForSeconds(3);
        TextMensajesText.text = "";
        TextMensajesObject.SetActive(false);
    }

}
