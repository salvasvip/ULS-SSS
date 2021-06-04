using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.PlayerLoop;

public class EnemyIA : MonoBehaviour
{
    NavMeshAgent agent;
    private bool inAttackRange, inPersecutionRange;
    public LiveCharacter live;
    [SerializeField] int damagePlayer = 5;
    [SerializeField] GameObject Player;
    [SerializeField] float persecutionRadius = 5.0f;
    [SerializeField] float attackRadius = 2.0f;
    [SerializeField] Animator alien;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        inPersecutionRange = Vector3.Distance(transform.position, Player.transform.position) < persecutionRadius;
        if (inPersecutionRange)
        {
            agent.SetDestination(Player.transform.position);
            alien.SetBool("Espera", false);
            alien.SetBool("Camina", true);
            inAttackRange = Vector3.Distance(transform.position, Player.transform.position) < attackRadius;
            if (inAttackRange)
            {
                alien.SetBool("Camina", false);
                alien.SetBool("Ataca", true);
                live.PlayerHealth(damagePlayer);
                StartCoroutine("TImeToLive");
            }
            else
            {
                alien.SetBool("Camina", true);
                alien.SetBool("Ataca", false);
            }
        }
        else
        {
            alien.SetBool("Espera", true);
            alien.SetBool("Camina", false);
        }
    }

    IEnumerator TImeToLive()
    {
        yield return new WaitForSeconds(3);
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, persecutionRadius);
    }
}