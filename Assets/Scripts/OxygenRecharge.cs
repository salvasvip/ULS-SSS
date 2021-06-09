using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenRecharge : MonoBehaviour
{
    public OxygenCountDown OxygenRemainingTime;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject ImageBotonE;
    [SerializeField] GameObject CylinderOxigeno;
    [SerializeField] AudioSource rechargeOxygenAudioSource;
    [SerializeField] Text TextMensajesText;
    private Renderer CylinderOxigenoRenderer;
    private bool usado = false;
    private bool inRange = false;
    
    void Start()
    {
        CylinderOxigenoRenderer = CylinderOxigeno.GetComponent<Renderer>();
    }

    void Update()
    {
        if(!usado && inRange)
        {
            ImageBotonE.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                OxigenoUsado();
            }
        }
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

    void OxigenoUsado()
    {
        usado=true;
        ImageBotonE.SetActive(false);
        rechargeOxygenAudioSource.Play();
        Color CilindroOxigenoColor = new Color(.5f,.1f,.1f,.5f);
        CylinderOxigenoRenderer.material.SetColor("_Color",CilindroOxigenoColor);
        OxygenRemainingTime.totalTime = 60;
        TextMensajesText.text = "tanque de oxigeno recargado";
        StartCoroutine(TimeToMessage());
    }

    IEnumerator TimeToMessage()
    {
        yield return new WaitForSeconds(3);
        TextMensajesText.text = "";
    }

}
