using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenRecharge : MonoBehaviour
{
    public OxygenCountDown OxygenRemainingTime;
    private bool inRechargeRange;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject ImageBotonE;
    [SerializeField] GameObject TextMensajesObject;
    [SerializeField] GameObject CylinderOxigeno;
    private Renderer CylinderOxigenoRenderer;
    [SerializeField] Text TextMensajesText;
    [SerializeField] float rechargeRadius = 3f;
    [SerializeField] AudioSource rechargeOxygenAudioSource;
    private bool usado = false;
    // Update is called once per frame
    void Start()
    {
        CylinderOxigenoRenderer = CylinderOxigeno.GetComponent<Renderer>();
    }
    void Update()
    {
        inRechargeRange = Vector3.Distance(transform.position, Player.transform.position) < rechargeRadius;
        if(inRechargeRange && !usado)
        {
            ImageBotonE.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                usado=true;
                OxigenoUsado();
            }
        }
        else
        {
            ImageBotonE.SetActive(false);
        }
    }

    void OxigenoUsado()
    {
        rechargeOxygenAudioSource.Play();
        ImageBotonE.SetActive(false);
        Color CilindroOxigenoColor = new Color(.5f,.1f,.1f,.5f);
        CylinderOxigenoRenderer.material.SetColor("_Color",CilindroOxigenoColor);
        OxygenRemainingTime.totalTime = 60;
        TextMensajesText.text = "tanque de oxigeno recargado";
        TextMensajesObject.SetActive(true);
        StartCoroutine("TimeToMessage");
        // Destroy(gameObject,5);
    }

    IEnumerator TimeToMessage()
    {
        yield return new WaitForSeconds(3);
        TextMensajesText.text = "";
        TextMensajesObject.SetActive(false);

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rechargeRadius);
    }
}
