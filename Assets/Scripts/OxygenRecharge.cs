using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenRecharge : MonoBehaviour
{
    [SerializeField] Text TextMensajes;
    public OxygenCountDown remainingTime;

    private bool inRechargeRange;
    [SerializeField] GameObject Player;
    [SerializeField] float rechargeRadius = 3f;
    // Update is called once per frame
    void Update()
    {
        inRechargeRange = Vector3.Distance(transform.position, Player.transform.position) < rechargeRadius;
        if (inRechargeRange && Input.GetKeyDown(KeyCode.E))
        {
            remainingTime.totalTime = 60;
            TextMensajes.text = "60 segundos mas de oxigeno";
            StartCoroutine("TimeToMessage");
            TimeToMessage();
            Destroy(gameObject,1);
        }
    }

    IEnumerator TimeToMessage()
    {
        yield return new WaitForSeconds(3);
        TextMensajes.text = "";
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rechargeRadius);
    }
}
